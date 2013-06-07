<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GENESTUB
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCmdline = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Argc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Argv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonFinish = New System.Windows.Forms.Button()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageArgs = New System.Windows.Forms.TabPage()
        Me.TabPageOut = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxStdOut = New System.Windows.Forms.TextBox()
        Me.TabPageErr = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxStdErr = New System.Windows.Forms.TextBox()
        Me.Env = New System.Windows.Forms.TabPage()
        Me.DataGridViewEnv = New System.Windows.Forms.DataGridView()
        Me.EnvName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnvValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelGetDllDirectory = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPageArgs.SuspendLayout()
        Me.TabPageOut.SuspendLayout()
        Me.TabPageErr.SuspendLayout()
        Me.Env.SuspendLayout()
        CType(Me.DataGridViewEnv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "このプログラムは以下のように呼ばれました"
        '
        'TextBoxCmdline
        '
        Me.TextBoxCmdline.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCmdline.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCmdline.Location = New System.Drawing.Point(6, 25)
        Me.TextBoxCmdline.Multiline = True
        Me.TextBoxCmdline.Name = "TextBoxCmdline"
        Me.TextBoxCmdline.ReadOnly = True
        Me.TextBoxCmdline.Size = New System.Drawing.Size(518, 50)
        Me.TextBoxCmdline.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Argc, Me.Argv})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(518, 165)
        Me.DataGridView1.TabIndex = 3
        '
        'Argc
        '
        Me.Argc.HeaderText = "Argc"
        Me.Argc.Name = "Argc"
        Me.Argc.ReadOnly = True
        Me.Argc.Width = 30
        '
        'Argv
        '
        Me.Argv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Argv.HeaderText = "Argv"
        Me.Argv.Name = "Argv"
        Me.Argv.ReadOnly = True
        '
        'ButtonFinish
        '
        Me.ButtonFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFinish.Location = New System.Drawing.Point(458, 296)
        Me.ButtonFinish.Name = "ButtonFinish"
        Me.ButtonFinish.Size = New System.Drawing.Size(92, 30)
        Me.ButtonFinish.TabIndex = 6
        Me.ButtonFinish.Text = "終了"
        Me.ButtonFinish.UseVisualStyleBackColor = True
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxResult.Location = New System.Drawing.Point(410, 302)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(42, 19)
        Me.TextBoxResult.TabIndex = 7
        Me.TextBoxResult.Text = "0"
        Me.TextBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "戻り値"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageArgs)
        Me.TabControl1.Controls.Add(Me.TabPageOut)
        Me.TabControl1.Controls.Add(Me.TabPageErr)
        Me.TabControl1.Controls.Add(Me.Env)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(538, 278)
        Me.TabControl1.TabIndex = 9
        Me.TabControl1.Tag = ""
        '
        'TabPageArgs
        '
        Me.TabPageArgs.Controls.Add(Me.DataGridView1)
        Me.TabPageArgs.Controls.Add(Me.TextBoxCmdline)
        Me.TabPageArgs.Controls.Add(Me.Label1)
        Me.TabPageArgs.Location = New System.Drawing.Point(4, 22)
        Me.TabPageArgs.Name = "TabPageArgs"
        Me.TabPageArgs.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageArgs.Size = New System.Drawing.Size(530, 252)
        Me.TabPageArgs.TabIndex = 0
        Me.TabPageArgs.Text = "Args"
        Me.TabPageArgs.UseVisualStyleBackColor = True
        '
        'TabPageOut
        '
        Me.TabPageOut.Controls.Add(Me.Label4)
        Me.TabPageOut.Controls.Add(Me.TextBoxStdOut)
        Me.TabPageOut.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOut.Name = "TabPageOut"
        Me.TabPageOut.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOut.Size = New System.Drawing.Size(530, 252)
        Me.TabPageOut.TabIndex = 2
        Me.TabPageOut.Text = "Out"
        Me.TabPageOut.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "標準出力"
        '
        'TextBoxStdOut
        '
        Me.TextBoxStdOut.Location = New System.Drawing.Point(11, 24)
        Me.TextBoxStdOut.Multiline = True
        Me.TextBoxStdOut.Name = "TextBoxStdOut"
        Me.TextBoxStdOut.Size = New System.Drawing.Size(503, 218)
        Me.TextBoxStdOut.TabIndex = 0
        '
        'TabPageErr
        '
        Me.TabPageErr.Controls.Add(Me.Label3)
        Me.TabPageErr.Controls.Add(Me.TextBoxStdErr)
        Me.TabPageErr.Location = New System.Drawing.Point(4, 22)
        Me.TabPageErr.Name = "TabPageErr"
        Me.TabPageErr.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageErr.Size = New System.Drawing.Size(530, 252)
        Me.TabPageErr.TabIndex = 1
        Me.TabPageErr.Text = "Err"
        Me.TabPageErr.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "標準エラー出力"
        '
        'TextBoxStdErr
        '
        Me.TextBoxStdErr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStdErr.Location = New System.Drawing.Point(11, 26)
        Me.TextBoxStdErr.Multiline = True
        Me.TextBoxStdErr.Name = "TextBoxStdErr"
        Me.TextBoxStdErr.Size = New System.Drawing.Size(507, 214)
        Me.TextBoxStdErr.TabIndex = 0
        '
        'Env
        '
        Me.Env.Controls.Add(Me.DataGridViewEnv)
        Me.Env.Controls.Add(Me.Label5)
        Me.Env.Location = New System.Drawing.Point(4, 22)
        Me.Env.Name = "Env"
        Me.Env.Padding = New System.Windows.Forms.Padding(3)
        Me.Env.Size = New System.Drawing.Size(530, 252)
        Me.Env.TabIndex = 3
        Me.Env.Text = "Env"
        Me.Env.UseVisualStyleBackColor = True
        '
        'DataGridViewEnv
        '
        Me.DataGridViewEnv.AllowUserToAddRows = False
        Me.DataGridViewEnv.AllowUserToDeleteRows = False
        Me.DataGridViewEnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEnv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnvName, Me.EnvValue})
        Me.DataGridViewEnv.Location = New System.Drawing.Point(8, 29)
        Me.DataGridViewEnv.Name = "DataGridViewEnv"
        Me.DataGridViewEnv.ReadOnly = True
        Me.DataGridViewEnv.RowHeadersVisible = False
        Me.DataGridViewEnv.RowTemplate.Height = 21
        Me.DataGridViewEnv.Size = New System.Drawing.Size(506, 206)
        Me.DataGridViewEnv.TabIndex = 1
        '
        'EnvName
        '
        Me.EnvName.HeaderText = "Name"
        Me.EnvName.Name = "EnvName"
        Me.EnvName.ReadOnly = True
        '
        'EnvValue
        '
        Me.EnvValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EnvValue.HeaderText = "Value"
        Me.EnvValue.Name = "EnvValue"
        Me.EnvValue.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "環境変数"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabelGetDllDirectory)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(530, 252)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Misc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LabelGetDllDirectory
        '
        Me.LabelGetDllDirectory.AutoSize = True
        Me.LabelGetDllDirectory.Location = New System.Drawing.Point(6, 14)
        Me.LabelGetDllDirectory.Name = "LabelGetDllDirectory"
        Me.LabelGetDllDirectory.Size = New System.Drawing.Size(98, 12)
        Me.LabelGetDllDirectory.TabIndex = 0
        Me.LabelGetDllDirectory.Text = "GetDllDirectory()="
        '
        'GENESTUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 332)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.ButtonFinish)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GENESTUB"
        Me.Text = "GENESTUB"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageArgs.ResumeLayout(False)
        Me.TabPageArgs.PerformLayout()
        Me.TabPageOut.ResumeLayout(False)
        Me.TabPageOut.PerformLayout()
        Me.TabPageErr.ResumeLayout(False)
        Me.TabPageErr.PerformLayout()
        Me.Env.ResumeLayout(False)
        Me.Env.PerformLayout()
        CType(Me.DataGridViewEnv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCmdline As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Argc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Argv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonFinish As System.Windows.Forms.Button
    Friend WithEvents TextBoxResult As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageArgs As System.Windows.Forms.TabPage
    Friend WithEvents TabPageErr As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStdErr As System.Windows.Forms.TextBox
    Friend WithEvents TabPageOut As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStdOut As System.Windows.Forms.TextBox
    Friend WithEvents Env As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewEnv As System.Windows.Forms.DataGridView
    Friend WithEvents EnvName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnvValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents LabelGetDllDirectory As System.Windows.Forms.Label

End Class
