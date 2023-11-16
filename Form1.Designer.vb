<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        label_title = New Label()
        label_first_name = New Label()
        text_box_first_name = New TextBox()
        Label1 = New Label()
        text_box_last_name = New TextBox()
        label_email = New Label()
        text_box_email = New TextBox()
        label_address = New Label()
        text_box_address = New TextBox()
        Label2 = New Label()
        text_box_phone = New TextBox()
        Label3 = New Label()
        check_box_email = New CheckBox()
        check_box_phone = New CheckBox()
        check_box_text = New CheckBox()
        button_submit = New Button()
        button_reset = New Button()
        label_age = New Label()
        text_box_age = New TextBox()
        SuspendLayout()
        ' 
        ' label_title
        ' 
        label_title.AutoSize = True
        label_title.Font = New Font("Old English Text MT", 36.0F, FontStyle.Bold, GraphicsUnit.Point)
        label_title.ForeColor = Color.Red
        label_title.Location = New Point(193, 27)
        label_title.Name = "label_title"
        label_title.Size = New Size(423, 57)
        label_title.TabIndex = 0
        label_title.Text = "Registration Form"
        ' 
        ' label_first_name
        ' 
        label_first_name.AutoSize = True
        label_first_name.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        label_first_name.ForeColor = Color.Red
        label_first_name.Location = New Point(57, 112)
        label_first_name.Name = "label_first_name"
        label_first_name.Size = New Size(131, 25)
        label_first_name.TabIndex = 1
        label_first_name.Text = "Firt Name "
        ' 
        ' text_box_first_name
        ' 
        text_box_first_name.Location = New Point(196, 112)
        text_box_first_name.Name = "text_box_first_name"
        text_box_first_name.Size = New Size(406, 23)
        text_box_first_name.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(57, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 25)
        Label1.TabIndex = 3
        Label1.Text = "Last Name "
        ' 
        ' text_box_last_name
        ' 
        text_box_last_name.Location = New Point(196, 170)
        text_box_last_name.Name = "text_box_last_name"
        text_box_last_name.Size = New Size(406, 23)
        text_box_last_name.TabIndex = 4
        ' 
        ' label_email
        ' 
        label_email.AutoSize = True
        label_email.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        label_email.ForeColor = Color.Red
        label_email.Location = New Point(57, 280)
        label_email.Name = "label_email"
        label_email.Size = New Size(87, 25)
        label_email.TabIndex = 9
        label_email.Text = "Email "
        ' 
        ' text_box_email
        ' 
        text_box_email.Location = New Point(196, 280)
        text_box_email.Name = "text_box_email"
        text_box_email.Size = New Size(406, 23)
        text_box_email.TabIndex = 10
        ' 
        ' label_address
        ' 
        label_address.AutoSize = True
        label_address.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        label_address.ForeColor = Color.Red
        label_address.Location = New Point(57, 333)
        label_address.Name = "label_address"
        label_address.Size = New Size(95, 25)
        label_address.TabIndex = 11
        label_address.Text = "Address"
        ' 
        ' text_box_address
        ' 
        text_box_address.Location = New Point(196, 333)
        text_box_address.Name = "text_box_address"
        text_box_address.Size = New Size(406, 23)
        text_box_address.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(56, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 25)
        Label2.TabIndex = 5
        Label2.Text = "Phone "
        ' 
        ' text_box_phone
        ' 
        text_box_phone.Location = New Point(196, 225)
        text_box_phone.Name = "text_box_phone"
        text_box_phone.Size = New Size(174, 23)
        text_box_phone.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(56, 384)
        Label3.Name = "Label3"
        Label3.Size = New Size(267, 25)
        Label3.TabIndex = 13
        Label3.Text = "Communication Method"
        ' 
        ' check_box_email
        ' 
        check_box_email.AutoSize = True
        check_box_email.FlatAppearance.BorderColor = Color.Red
        check_box_email.FlatAppearance.CheckedBackColor = Color.Black
        check_box_email.FlatStyle = FlatStyle.Flat
        check_box_email.Font = New Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        check_box_email.ForeColor = Color.Red
        check_box_email.Location = New Point(339, 386)
        check_box_email.Name = "check_box_email"
        check_box_email.Size = New Size(74, 25)
        check_box_email.TabIndex = 14
        check_box_email.Text = "Email"
        check_box_email.TextAlign = ContentAlignment.MiddleCenter
        check_box_email.UseVisualStyleBackColor = True
        ' 
        ' check_box_phone
        ' 
        check_box_phone.AutoSize = True
        check_box_phone.FlatAppearance.BorderColor = Color.Red
        check_box_phone.FlatAppearance.CheckedBackColor = Color.Black
        check_box_phone.FlatStyle = FlatStyle.Flat
        check_box_phone.Font = New Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        check_box_phone.ForeColor = Color.Red
        check_box_phone.Location = New Point(422, 386)
        check_box_phone.Name = "check_box_phone"
        check_box_phone.Size = New Size(76, 25)
        check_box_phone.TabIndex = 15
        check_box_phone.Text = "Phone"
        check_box_phone.TextAlign = ContentAlignment.MiddleCenter
        check_box_phone.UseVisualStyleBackColor = True
        ' 
        ' check_box_text
        ' 
        check_box_text.AutoSize = True
        check_box_text.FlatAppearance.BorderColor = Color.Red
        check_box_text.FlatStyle = FlatStyle.Flat
        check_box_text.Font = New Font("Modern No. 20", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        check_box_text.ForeColor = Color.Red
        check_box_text.Location = New Point(507, 386)
        check_box_text.Name = "check_box_text"
        check_box_text.Size = New Size(61, 25)
        check_box_text.TabIndex = 16
        check_box_text.Text = "Text"
        check_box_text.TextAlign = ContentAlignment.MiddleCenter
        check_box_text.UseVisualStyleBackColor = True
        ' 
        ' button_submit
        ' 
        button_submit.BackColor = Color.Black
        button_submit.BackgroundImageLayout = ImageLayout.None
        button_submit.Cursor = Cursors.Hand
        button_submit.FlatAppearance.BorderColor = Color.Red
        button_submit.FlatAppearance.BorderSize = 2
        button_submit.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder
        button_submit.FlatAppearance.MouseOverBackColor = Color.Maroon
        button_submit.FlatStyle = FlatStyle.Flat
        button_submit.Font = New Font("Old English Text MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        button_submit.ForeColor = Color.White
        button_submit.Location = New Point(193, 480)
        button_submit.Name = "button_submit"
        button_submit.Size = New Size(177, 48)
        button_submit.TabIndex = 17
        button_submit.Text = "Submit"
        button_submit.UseVisualStyleBackColor = False
        ' 
        ' button_reset
        ' 
        button_reset.BackColor = Color.Black
        button_reset.BackgroundImageLayout = ImageLayout.None
        button_reset.Cursor = Cursors.Hand
        button_reset.FlatAppearance.BorderColor = Color.Red
        button_reset.FlatAppearance.BorderSize = 2
        button_reset.FlatAppearance.MouseDownBackColor = SystemColors.ActiveBorder
        button_reset.FlatAppearance.MouseOverBackColor = Color.Maroon
        button_reset.FlatStyle = FlatStyle.Flat
        button_reset.Font = New Font("Old English Text MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        button_reset.ForeColor = Color.White
        button_reset.Location = New Point(422, 480)
        button_reset.Name = "button_reset"
        button_reset.Size = New Size(177, 48)
        button_reset.TabIndex = 18
        button_reset.Text = "Reset"
        button_reset.UseVisualStyleBackColor = False
        ' 
        ' label_age
        ' 
        label_age.AutoSize = True
        label_age.Font = New Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        label_age.ForeColor = Color.Red
        label_age.Location = New Point(407, 225)
        label_age.Name = "label_age"
        label_age.Size = New Size(52, 25)
        label_age.TabIndex = 7
        label_age.Text = "Age"
        ' 
        ' text_box_age
        ' 
        text_box_age.Location = New Point(480, 225)
        text_box_age.Name = "text_box_age"
        text_box_age.Size = New Size(119, 23)
        text_box_age.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(726, 600)
        Controls.Add(text_box_age)
        Controls.Add(label_age)
        Controls.Add(button_reset)
        Controls.Add(button_submit)
        Controls.Add(check_box_text)
        Controls.Add(check_box_phone)
        Controls.Add(check_box_email)
        Controls.Add(Label3)
        Controls.Add(text_box_phone)
        Controls.Add(Label2)
        Controls.Add(text_box_address)
        Controls.Add(label_address)
        Controls.Add(text_box_email)
        Controls.Add(label_email)
        Controls.Add(text_box_last_name)
        Controls.Add(Label1)
        Controls.Add(text_box_first_name)
        Controls.Add(label_first_name)
        Controls.Add(label_title)
        Cursor = Cursors.Hand
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_title As Label
    Friend WithEvents label_first_name As Label
    Friend WithEvents text_box_first_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents text_box_last_name As TextBox
    Friend WithEvents label_email As Label
    Friend WithEvents text_box_email As TextBox
    Friend WithEvents label_address As Label
    Friend WithEvents text_box_address As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents text_box_phone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents check_box_email As CheckBox
    Friend WithEvents check_box_phone As CheckBox
    Friend WithEvents check_box_text As CheckBox
    Friend WithEvents button_submit As Button
    Friend WithEvents button_reset As Button
    Friend WithEvents label_age As Label
    Friend WithEvents text_box_age As TextBox
End Class
