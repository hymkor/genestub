Imports System.Runtime.InteropServices

Public Class GENESTUB
    Private Declare Auto Function GetDllDirectory Lib "kernel32.dll" Alias "GetDllDirectory" _
        (ByVal size As Int32, <MarshalAs(UnmanagedType.LPTStr)> ByVal buffer As System.Text.StringBuilder) As Int32

    Private Declare Auto Function SetDllDirectory Lib "kernel32.dll" Alias "SetDllDirectoryW" (ByVal path As String) As Boolean

    Private Sub GENESTUB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '*** キャプションに自分のコマンド名を置く ***
        Dim argv As String() = System.Environment.GetCommandLineArgs()
        Me.Text = argv(0)

        '*** コマンドライン全部をテキストボックスへ置く
        Me.TextBoxCmdline.Text = System.Environment.CommandLine

        '*** DataGridView に引数を一つずつおく ***
        Dim argc As Integer = 0
        For Each arg1 As String In argv
            Me.DataGridView1.Rows.Add(argc.ToString(), arg1)
            argc += 1
        Next

        '*** 環境変数一覧 ***
        For Each pair As DictionaryEntry In System.Environment.GetEnvironmentVariables()
            Me.DataGridViewEnv.Rows.Add(pair.Key, pair.Value)
        Next

        'SetDllDirectory("C:\")

        Dim buffer As New System.Text.StringBuilder(1024)
        If GetDllDirectory(buffer.Capacity, buffer) > 0 Then
            Me.LabelGetDllDirectory.Text = String.Format("{0}=""{1}""", Me.LabelGetDllDirectory.Text, If(buffer.ToString(), "(zero)"))
        Else
            Me.LabelGetDllDirectory.Text = String.Format("{0}=Nothing", Me.LabelGetDllDirectory.Text)
        End If
    End Sub

    Private Sub ButtonFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFinish.Click
        Me.Close()
    End Sub

    Private Sub GENESTUB_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Integer.TryParse(Me.TextBoxResult.Text, System.Environment.ExitCode) Then
            MsgBox("Result is Not A Number!")
            e.Cancel = True
        End If
        If Not String.IsNullOrWhiteSpace(Me.TextBoxStdOut.Text) Then
            Console.Out.WriteLine(Me.TextBoxStdOut.Text)
        End If
        If Not String.IsNullOrWhiteSpace(Me.TextBoxStdErr.Text) Then
            Console.Error.WriteLine(Me.TextBoxStdErr.Text)
        End If
    End Sub
End Class
