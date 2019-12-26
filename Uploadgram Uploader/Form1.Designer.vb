<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtBoxPath = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.LnkLblFileURL = New System.Windows.Forms.LinkLabel()
        Me.LblUrl = New System.Windows.Forms.Label()
        Me.LblCredits = New System.Windows.Forms.Label()
        Me.ChkBxDirect = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBoxPath
        '
        Me.TxtBoxPath.Location = New System.Drawing.Point(13, 37)
        Me.TxtBoxPath.Name = "TxtBoxPath"
        Me.TxtBoxPath.ReadOnly = True
        Me.TxtBoxPath.Size = New System.Drawing.Size(694, 20)
        Me.TxtBoxPath.TabIndex = 0
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(713, 36)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 21)
        Me.BtnBrowse.TabIndex = 1
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'BtnUpload
        '
        Me.BtnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 69.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.Location = New System.Drawing.Point(13, 80)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(775, 121)
        Me.BtnUpload.TabIndex = 2
        Me.BtnUpload.Text = "Upload"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'LnkLblFileURL
        '
        Me.LnkLblFileURL.AutoSize = True
        Me.LnkLblFileURL.Location = New System.Drawing.Point(82, 246)
        Me.LnkLblFileURL.Name = "LnkLblFileURL"
        Me.LnkLblFileURL.Size = New System.Drawing.Size(0, 13)
        Me.LnkLblFileURL.TabIndex = 3
        '
        'LblUrl
        '
        Me.LblUrl.AutoSize = True
        Me.LblUrl.Location = New System.Drawing.Point(12, 246)
        Me.LblUrl.Name = "LblUrl"
        Me.LblUrl.Size = New System.Drawing.Size(73, 13)
        Me.LblUrl.TabIndex = 4
        Me.LblUrl.Text = "Your file URL:"
        '
        'LblCredits
        '
        Me.LblCredits.AutoSize = True
        Me.LblCredits.Location = New System.Drawing.Point(507, 246)
        Me.LblCredits.Name = "LblCredits"
        Me.LblCredits.Size = New System.Drawing.Size(281, 13)
        Me.LblCredits.TabIndex = 5
        Me.LblCredits.Text = "Uploadgram by ShiSHcat - Uploader by TheLifeGamingYT"
        '
        'ChkBxDirect
        '
        Me.ChkBxDirect.AutoSize = True
        Me.ChkBxDirect.Location = New System.Drawing.Point(15, 218)
        Me.ChkBxDirect.Name = "ChkBxDirect"
        Me.ChkBxDirect.Size = New System.Drawing.Size(223, 17)
        Me.ChkBxDirect.TabIndex = 6
        Me.ChkBxDirect.Text = "Directly open file if the upload is succesful"
        Me.ChkBxDirect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Your file local path:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 278)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkBxDirect)
        Me.Controls.Add(Me.LblCredits)
        Me.Controls.Add(Me.LblUrl)
        Me.Controls.Add(Me.LnkLblFileURL)
        Me.Controls.Add(Me.BtnUpload)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TxtBoxPath)
        Me.Name = "MainForm"
        Me.Text = "Uploadgram Uploader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtBoxPath As TextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnUpload As Button
    Friend WithEvents LnkLblFileURL As LinkLabel
    Friend WithEvents LblUrl As Label
    Friend WithEvents LblCredits As Label
    Friend WithEvents ChkBxDirect As CheckBox
    Friend WithEvents Label1 As Label
End Class
