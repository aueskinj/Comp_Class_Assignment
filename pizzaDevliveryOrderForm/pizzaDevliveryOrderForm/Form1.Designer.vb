<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1261, 738)
        Name = "Form1"
        Text = "Pizza Delivery Order Form"
        ResumeLayout(False)
    End Sub

    ' Custom method to create controls
    Private Sub InitializeCustomControls()
        ' Customer Information Section
        Dim customerFrame As New System.Windows.Forms.GroupBox()
        customerFrame.Text = "Customer Information"
        customerFrame.Location = New System.Drawing.Point(10, 10)
        customerFrame.Size = New System.Drawing.Size(200, 200)
        Controls.Add(customerFrame)

        Dim labels() As String = {"First Name:", "Last Name:", "Address Line 1:", "Address Line 2:", "City:", "PIN Code:"}
        Dim yPosition As Integer = 20

        For i As Integer = 0 To labels.Length - 1
            Dim label As New System.Windows.Forms.Label()
            label.Text = labels(i)
            label.Location = New System.Drawing.Point(10, yPosition)
            customerFrame.Controls.Add(label)

            Dim textBox As New System.Windows.Forms.TextBox()
            textBox.Location = New System.Drawing.Point(120, yPosition)
            customerFrame.Controls.Add(textBox)

            yPosition += 30
        Next

        Dim saveCustomerButton As New System.Windows.Forms.Button()
        saveCustomerButton.Text = "Save Customer"
        saveCustomerButton.Location = New System.Drawing.Point(10, yPosition)
        customerFrame.Controls.Add(saveCustomerButton)

        ' Continue with the rest of your controls...
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        ' Implement the logic to clear the form
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
