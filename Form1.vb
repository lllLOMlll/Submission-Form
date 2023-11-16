Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub button_submit_Click(sender As Object, e As EventArgs) Handles button_submit.Click
        'Initialize variables
        Dim firstName, lastName, age, email, address, phone, communicationEmail, communicationPhone, communicationText As String
        Dim isFormValid As Boolean = True
        'Assign value to the variables
        firstName = text_box_first_name.Text
        lastName = text_box_last_name.Text
        age = text_box_age.Text
        email = text_box_email.Text
        address = text_box_address.Text
        phone = text_box_phone.Text


        'VALIDATION
        'First Name
        If String.IsNullOrEmpty(firstName) Then
            MsgBox("First Name cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        End If
        'Last Name
        If String.IsNullOrEmpty(lastName) Then
            MsgBox("Last Name cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        End If
        'Age
        If String.IsNullOrEmpty(age) Then
            MsgBox("Age cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            Dim ageValue As Integer
            If Integer.TryParse(age, ageValue) Then
                If ageValue < 18 OrElse ageValue > 110 Then
                    MsgBox("Age must be between 18 and 110", MsgBoxStyle.Exclamation, "Input")
                    isFormValid = False
                End If
            Else
                MsgBox("Please enter a valid age", MsgBoxStyle.Exclamation, "Input")
                isFormValid = False
            End If
        End If
        'Email
        If String.IsNullOrEmpty(email) Then
            MsgBox("Email cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            ' Validate email format
            ' \S+ matches any non-whitespace character
            Dim emailPattern As String = "^\S+@\S+\.\S+$"
            If Regex.IsMatch(email, emailPattern) Then
            Else
                MsgBox("Please enter a valid email address", MsgBoxStyle.Exclamation, "Input")
                isFormValid = False
            End If
        End If
        'Address
        If String.IsNullOrEmpty(address) Then
            MsgBox("Adress cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        End If
        'Phone
        If String.IsNullOrEmpty(phone) Then
            MsgBox("Phone cannot be empty", MsgBoxStyle.Exclamation, "Input")
            isFormValid = False
        Else
            Dim phonePattern As String = "^\d{3}-\d{3}-\d{4}$"
            If Regex.IsMatch(phone, phonePattern) Then
            Else
                MsgBox("Phone must be in the format XXX-XXX-XXXX", MsgBoxStyle.Exclamation, "Input")
                isFormValid = False
            End If
        End If

        If check_box_email.Checked Then
            communicationEmail = "Yes"
        Else
            communicationEmail = "No"
        End If

        If check_box_phone.Checked Then
            communicationPhone = "Yes"
        Else
            communicationPhone = "No"
        End If

        If check_box_text.Checked Then
            communicationText = "Yes"
        Else
            communicationText = "No"
        End If

        If isFormValid Then
            'DISPLAY FORM (only if the form is valid)
            MsgBox("================" & vbNewLine &
                   " USER INFORMATION" & vbNewLine &
                   "================" & vbNewLine & vbNewLine &
                   "First Name: " & firstName & vbNewLine &
                   "Last Name : " & lastName & vbNewLine &
                   "Phone : " & phone & vbNewLine &
                   "Age : " & age & vbNewLine &
                   "Email : " & email & vbNewLine &
                   "Address : " & address & vbNewLine & vbNewLine &
                   "COMMUNICATION METHOD : " & vbNewLine &
                   "     Email:" & communicationEmail & vbNewLine &
                   "     Phone:" & communicationPhone & vbNewLine &
                   "     Text: " & communicationText, MsgBoxStyle.Information, "User Information")

            'Reset the form
            text_box_first_name.Text = ""
            text_box_last_name.Text = ""
            text_box_age.Text = ""
            text_box_email.Text = ""
            text_box_address.Text = ""
            text_box_phone.Text = ""
            check_box_email.Checked = False
            check_box_phone.Checked = False
            check_box_text.Checked = False
        End If


    End Sub


    Private Sub button_reset_Click_1(sender As Object, e As EventArgs) Handles button_reset.Click
        ' Clear the first name text box
        text_box_first_name.Text = ""
        text_box_last_name.Text = ""
        text_box_age.Text = ""
        text_box_email.Text = ""
        text_box_address.Text = ""
        text_box_phone.Text = ""
        check_box_email.Checked = False
        check_box_phone.Checked = False
        check_box_text.Checked = False
    End Sub

    Private Sub check_box_phone_CheckedChanged(sender As Object, e As EventArgs) Handles check_box_phone.CheckedChanged

    End Sub
End Class

