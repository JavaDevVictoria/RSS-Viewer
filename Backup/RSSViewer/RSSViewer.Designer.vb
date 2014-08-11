<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RSSViewer
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
    Me.lbItems = New System.Windows.Forms.ListBox
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
    Me.Panel3 = New System.Windows.Forms.Panel
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.linkItemURL = New System.Windows.Forms.LinkLabel
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Label2 = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.linkChannel = New System.Windows.Forms.LinkLabel
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblDescription = New System.Windows.Forms.Label
    Me.lblTitle = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnRefresh = New System.Windows.Forms.Button
    Me.tbChannel = New System.Windows.Forms.TextBox
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'WebBrowser1
    '
    Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
    Me.WebBrowser1.Name = "WebBrowser1"
    Me.WebBrowser1.Size = New System.Drawing.Size(462, 323)
    Me.WebBrowser1.TabIndex = 0
    '
    'lbItems
    '
    Me.lbItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbItems.FormattingEnabled = True
    Me.lbItems.Location = New System.Drawing.Point(12, 3)
    Me.lbItems.Name = "lbItems"
    Me.lbItems.Size = New System.Drawing.Size(250, 355)
    Me.lbItems.TabIndex = 0
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 126)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.lbItems)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
    Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
    Me.SplitContainer1.Size = New System.Drawing.Size(744, 372)
    Me.SplitContainer1.SplitterDistance = 261
    Me.SplitContainer1.SplitterWidth = 2
    Me.SplitContainer1.TabIndex = 11
    Me.SplitContainer1.Text = "SplitContainer1"
    '
    'Panel3
    '
    Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel3.Controls.Add(Me.WebBrowser1)
    Me.Panel3.Location = New System.Drawing.Point(3, 31)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(466, 327)
    Me.Panel3.TabIndex = 3
    '
    'Panel2
    '
    Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel2.Controls.Add(Me.linkItemURL)
    Me.Panel2.Location = New System.Drawing.Point(3, 3)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(464, 25)
    Me.Panel2.TabIndex = 0
    '
    'linkItemURL
    '
    Me.linkItemURL.AutoSize = True
    Me.linkItemURL.Location = New System.Drawing.Point(2, 4)
    Me.linkItemURL.Name = "linkItemURL"
    Me.linkItemURL.Size = New System.Drawing.Size(65, 13)
    Me.linkItemURL.TabIndex = 0
    Me.linkItemURL.TabStop = True
    Me.linkItemURL.Text = "linkItemURL"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.GroupBox1)
    Me.Panel1.Controls.Add(Me.btnRefresh)
    Me.Panel1.Controls.Add(Me.tbChannel)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(744, 126)
    Me.Panel1.TabIndex = 12
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 15)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 17
    Me.Label2.Text = "Channel"
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.linkChannel)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.lblDescription)
    Me.GroupBox1.Controls.Add(Me.lblTitle)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(718, 79)
    Me.GroupBox1.TabIndex = 16
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Channel Properties"
    '
    'linkChannel
    '
    Me.linkChannel.AutoSize = True
    Me.linkChannel.Location = New System.Drawing.Point(82, 60)
    Me.linkChannel.Name = "linkChannel"
    Me.linkChannel.Size = New System.Drawing.Size(62, 13)
    Me.linkChannel.TabIndex = 15
    Me.linkChannel.TabStop = True
    Me.linkChannel.Text = "linkChannel"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(27, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Title"
    '
    'lblDescription
    '
    Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblDescription.Location = New System.Drawing.Point(82, 38)
    Me.lblDescription.Name = "lblDescription"
    Me.lblDescription.Size = New System.Drawing.Size(630, 13)
    Me.lblDescription.TabIndex = 14
    Me.lblDescription.Text = "Label5"
    '
    'lblTitle
    '
    Me.lblTitle.AutoSize = True
    Me.lblTitle.Location = New System.Drawing.Point(82, 16)
    Me.lblTitle.Name = "lblTitle"
    Me.lblTitle.Size = New System.Drawing.Size(39, 13)
    Me.lblTitle.TabIndex = 3
    Me.lblTitle.Text = "Label2"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 60)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(27, 13)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "Link"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 38)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(60, 13)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "Description"
    '
    'btnRefresh
    '
    Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRefresh.Location = New System.Drawing.Point(638, 6)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(92, 30)
    Me.btnRefresh.TabIndex = 1
    Me.btnRefresh.Text = "Refresh"
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'tbChannel
    '
    Me.tbChannel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbChannel.Location = New System.Drawing.Point(61, 12)
    Me.tbChannel.Name = "tbChannel"
    Me.tbChannel.Size = New System.Drawing.Size(571, 20)
    Me.tbChannel.TabIndex = 0
    '
    'RSSViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(744, 498)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "RSSViewer"
    Me.Text = "RSS Viewer"
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
  Friend WithEvents lbItems As System.Windows.Forms.ListBox
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents tbChannel As System.Windows.Forms.TextBox
  Friend WithEvents btnRefresh As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents linkChannel As System.Windows.Forms.LinkLabel
  Friend WithEvents lblDescription As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblTitle As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents linkItemURL As System.Windows.Forms.LinkLabel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
