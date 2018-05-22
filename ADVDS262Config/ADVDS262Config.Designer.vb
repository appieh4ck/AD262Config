<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADVDS262Config
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtComputerName = New System.Windows.Forms.TextBox()
        Me.txtChangePCDescription = New System.Windows.Forms.TextBox()
        Me.btnChangePCName = New MaterialSkin.Controls.MaterialFlatButton()
        Me.mtbControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IpAddressControl4 = New SEG.Controls.IPAddressControl()
        Me.IpAddressControl3 = New SEG.Controls.IPAddressControl()
        Me.IpAddressControl2 = New SEG.Controls.IPAddressControl()
        Me.IpAddressControl1 = New SEG.Controls.IPAddressControl()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.OpenExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtbControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtComputerName
        '
        Me.txtComputerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComputerName.Location = New System.Drawing.Point(6, 35)
        Me.txtComputerName.MaxLength = 14
        Me.txtComputerName.Name = "txtComputerName"
        Me.txtComputerName.Size = New System.Drawing.Size(194, 20)
        Me.txtComputerName.TabIndex = 2
        '
        'txtChangePCDescription
        '
        Me.txtChangePCDescription.Location = New System.Drawing.Point(3, 91)
        Me.txtChangePCDescription.Name = "txtChangePCDescription"
        Me.txtChangePCDescription.Size = New System.Drawing.Size(194, 20)
        Me.txtChangePCDescription.TabIndex = 3
        '
        'btnChangePCName
        '
        Me.btnChangePCName.AutoSize = True
        Me.btnChangePCName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnChangePCName.Depth = 0
        Me.btnChangePCName.Location = New System.Drawing.Point(219, 26)
        Me.btnChangePCName.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnChangePCName.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnChangePCName.Name = "btnChangePCName"
        Me.btnChangePCName.Primary = False
        Me.btnChangePCName.Size = New System.Drawing.Size(185, 36)
        Me.btnChangePCName.TabIndex = 6
        Me.btnChangePCName.Text = "Change computer name"
        Me.btnChangePCName.UseVisualStyleBackColor = True
        '
        'mtbControl
        '
        Me.mtbControl.Controls.Add(Me.TabPage1)
        Me.mtbControl.Controls.Add(Me.TabPage2)
        Me.mtbControl.Controls.Add(Me.TabPage3)
        Me.mtbControl.Depth = 0
        Me.mtbControl.Location = New System.Drawing.Point(12, 108)
        Me.mtbControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.mtbControl.Name = "mtbControl"
        Me.mtbControl.SelectedIndex = 0
        Me.mtbControl.Size = New System.Drawing.Size(541, 289)
        Me.mtbControl.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MaterialRaisedButton1)
        Me.TabPage1.Controls.Add(Me.btnChangePCName)
        Me.TabPage1.Controls.Add(Me.txtComputerName)
        Me.TabPage1.Controls.Add(Me.txtChangePCDescription)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(533, 263)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Change player name"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(219, 81)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(185, 38)
        Me.MaterialRaisedButton1.TabIndex = 7
        Me.MaterialRaisedButton1.Text = "Change player description"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.IpAddressControl4)
        Me.TabPage2.Controls.Add(Me.IpAddressControl3)
        Me.TabPage2.Controls.Add(Me.IpAddressControl2)
        Me.TabPage2.Controls.Add(Me.IpAddressControl1)
        Me.TabPage2.Controls.Add(Me.MaterialFlatButton2)
        Me.TabPage2.Controls.Add(Me.MaterialLabel4)
        Me.TabPage2.Controls.Add(Me.MaterialLabel3)
        Me.TabPage2.Controls.Add(Me.MaterialLabel2)
        Me.TabPage2.Controls.Add(Me.MaterialLabel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(533, 263)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Network configuration"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'IpAddressControl4
        '
        Me.IpAddressControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IpAddressControl4.BackColor = System.Drawing.Color.White
        Me.IpAddressControl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAddressControl4.ForeColor = System.Drawing.Color.Black
        Me.IpAddressControl4.IP = "   .   .   .   "
        Me.IpAddressControl4.Location = New System.Drawing.Point(140, 130)
        Me.IpAddressControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.IpAddressControl4.Name = "IpAddressControl4"
        Me.IpAddressControl4.Size = New System.Drawing.Size(175, 29)
        Me.IpAddressControl4.TabIndex = 12
        '
        'IpAddressControl3
        '
        Me.IpAddressControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IpAddressControl3.BackColor = System.Drawing.Color.White
        Me.IpAddressControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAddressControl3.ForeColor = System.Drawing.Color.Black
        Me.IpAddressControl3.IP = "   .   .   .   "
        Me.IpAddressControl3.Location = New System.Drawing.Point(140, 94)
        Me.IpAddressControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.IpAddressControl3.Name = "IpAddressControl3"
        Me.IpAddressControl3.Size = New System.Drawing.Size(175, 29)
        Me.IpAddressControl3.TabIndex = 11
        '
        'IpAddressControl2
        '
        Me.IpAddressControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IpAddressControl2.BackColor = System.Drawing.Color.White
        Me.IpAddressControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAddressControl2.ForeColor = System.Drawing.Color.Black
        Me.IpAddressControl2.IP = "   .   .   .   "
        Me.IpAddressControl2.Location = New System.Drawing.Point(140, 56)
        Me.IpAddressControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.IpAddressControl2.Name = "IpAddressControl2"
        Me.IpAddressControl2.Size = New System.Drawing.Size(175, 29)
        Me.IpAddressControl2.TabIndex = 10
        '
        'IpAddressControl1
        '
        Me.IpAddressControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.IpAddressControl1.BackColor = System.Drawing.Color.White
        Me.IpAddressControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpAddressControl1.ForeColor = System.Drawing.Color.Black
        Me.IpAddressControl1.IP = "   .   .   .   "
        Me.IpAddressControl1.Location = New System.Drawing.Point(140, 21)
        Me.IpAddressControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.IpAddressControl1.Name = "IpAddressControl1"
        Me.IpAddressControl1.Size = New System.Drawing.Size(175, 29)
        Me.IpAddressControl1.TabIndex = 9
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.BackColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(354, 221)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(172, 36)
        Me.MaterialFlatButton2.TabIndex = 8
        Me.MaterialFlatButton2.Text = "Set network settings"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(7, 140)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(39, 19)
        Me.MaterialLabel4.TabIndex = 6
        Me.MaterialLabel4.Text = "DNS"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(7, 104)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(116, 19)
        Me.MaterialLabel3.TabIndex = 4
        Me.MaterialLabel3.Text = "Default gateway"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(7, 66)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(96, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Subnet mask"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(7, 31)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(22, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "IP"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MaterialLabel5)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.MaterialRaisedButton2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(533, 263)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Proxy settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.mtbControl
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(593, 39)
        Me.MaterialTabSelector1.TabIndex = 9
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(485, 463)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialFlatButton1.TabIndex = 10
        Me.MaterialFlatButton1.Text = "Reboot"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(268, 48)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(183, 27)
        Me.MaterialRaisedButton2.TabIndex = 0
        Me.MaterialRaisedButton2.Text = "Set proxy settings"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 20)
        Me.TextBox1.TabIndex = 1
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(6, 13)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(314, 19)
        Me.MaterialLabel5.TabIndex = 2
        Me.MaterialLabel5.Text = "Input proxy address and port (something:port)"
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenExcelToolStripMenuItem})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(133, 26)
        '
        'OpenExcelToolStripMenuItem
        '
        Me.OpenExcelToolStripMenuItem.Name = "OpenExcelToolStripMenuItem"
        Me.OpenExcelToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.OpenExcelToolStripMenuItem.Text = "Open excel"
        '
        'ADVDS262Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 514)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.mtbControl)
        Me.Name = "ADVDS262Config"
        Me.Text = "Kimeru "
        Me.mtbControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComputerName As TextBox
    Friend WithEvents txtChangePCDescription As TextBox
    Friend WithEvents btnChangePCName As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents mtbControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents IpAddressControl4 As SEG.Controls.IPAddressControl
    Friend WithEvents IpAddressControl3 As SEG.Controls.IPAddressControl
    Friend WithEvents IpAddressControl2 As SEG.Controls.IPAddressControl
    Friend WithEvents IpAddressControl1 As SEG.Controls.IPAddressControl
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents OpenExcelToolStripMenuItem As ToolStripMenuItem
End Class
