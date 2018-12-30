<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AccountInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.BTN_Check = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.AllowDrop = True
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(0, 44)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(434, 412)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Email"
        Me.ColumnHeader1.Width = 205
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        Me.ColumnHeader2.Width = 119
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data N°"
        Me.ColumnHeader3.Width = 106
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountInfoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 26)
        '
        'AccountInfoToolStripMenuItem
        '
        Me.AccountInfoToolStripMenuItem.Image = CType(resources.GetObject("AccountInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AccountInfoToolStripMenuItem.Name = "AccountInfoToolStripMenuItem"
        Me.AccountInfoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AccountInfoToolStripMenuItem.Text = "Leaked Info"
        '
        'txtmail
        '
        Me.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmail.Location = New System.Drawing.Point(3, 6)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(326, 21)
        Me.txtmail.TabIndex = 1
        '
        'BTN_Check
        '
        Me.BTN_Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Check.Location = New System.Drawing.Point(335, 5)
        Me.BTN_Check.Name = "BTN_Check"
        Me.BTN_Check.Size = New System.Drawing.Size(92, 23)
        Me.BTN_Check.TabIndex = 2
        Me.BTN_Check.Text = "Check"
        Me.BTN_Check.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(82, 28)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(258, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Insert an email or drag && drop a list of emails/Combo"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Navy
        Me.LinkLabel2.Location = New System.Drawing.Point(5, 459)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(107, 13)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "CODED BY X-SLAYER"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel3.Location = New System.Drawing.Point(278, 459)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(149, 13)
        Me.LinkLabel3.TabIndex = 5
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "https://haveibeenpwned.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 478)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BTN_Check)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.LV)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Breaches Emails v0.2 | X-SLAYER"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents BTN_Check As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AccountInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel

End Class
