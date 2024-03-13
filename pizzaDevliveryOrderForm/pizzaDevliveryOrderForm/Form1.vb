Imports System.Windows.Forms

Public Class PizzaOrderForm
    Inherits Form

    Public Sub New()
        Me.Text = "Pizza Delivery Order Form"

        ' Customer Information Section
        Dim customerFrame As New GroupBox()
        customerFrame.Text = "Customer Information"
        customerFrame.Location = New Point(10, 10)
        customerFrame.Size = New Size(200, 200)
        Me.Controls.Add(customerFrame)

        Dim labels() As String = {"First Name:", "Last Name:", "Address Line 1:", "Address Line 2:", "City:", "PIN Code:"}
        Dim yPosition As Integer = 20

        For i As Integer = 0 To labels.Length - 1
            Dim label As New Label()
            label.Text = labels(i)
            label.Location = New Point(10, yPosition)
            customerFrame.Controls.Add(label)

            Dim textBox As New TextBox()
            textBox.Location = New Point(120, yPosition)
            customerFrame.Controls.Add(textBox)

            yPosition += 30
        Next

        Dim saveCustomerButton As New Button()
        saveCustomerButton.Text = "Save Customer"
        saveCustomerButton.Location = New Point(10, yPosition)
        customerFrame.Controls.Add(saveCustomerButton)

        ' Pizza Order Details Section
        Dim pizzaFrame As New GroupBox()
        pizzaFrame.Text = "Pizza Order Details"
        pizzaFrame.Location = New Point(220, 10)
        pizzaFrame.Size = New Size(200, 200)
        Me.Controls.Add(pizzaFrame)

        ' Include your pizza options, sizes, and extras here with Add Item button

        ' Drinks Section
        Dim drinksFrame As New GroupBox()
        drinksFrame.Text = "Drinks"
        drinksFrame.Location = New Point(10, 220)
        drinksFrame.Size = New Size(200, 100)
        Me.Controls.Add(drinksFrame)

        ' Include drink options and quantity selection here

        ' Additional Fields
        Dim additionalFrame As New GroupBox()
        additionalFrame.Text = "Additional Fields"
        additionalFrame.Location = New Point(220, 220)
        additionalFrame.Size = New Size(200, 150)
        Me.Controls.Add(additionalFrame)

        Dim printNoteButton As New Button()
        printNoteButton.Text = "Print Delivery Note"
        printNoteButton.Location = New Point(10, 20)
        additionalFrame.Controls.Add(printNoteButton)

        Dim clearButton As New Button()
        clearButton.Text = "Clear"
        clearButton.Location = New Point(10, 50)
        AddHandler clearButton.Click, AddressOf ClearForm
        additionalFrame.Controls.Add(clearButton)

        Dim orderValueLabel As New Label()
        orderValueLabel.Text = "Order Value:"
        orderValueLabel.Location = New Point(10, 80)
        additionalFrame.Controls.Add(orderValueLabel)

        Dim deliveryChargeLabel As New Label()
        deliveryChargeLabel.Text = "Delivery Charge:"
        deliveryChargeLabel.Location = New Point(10, 110)
        additionalFrame.Controls.Add(deliveryChargeLabel)

        Dim orderTotalLabel As New Label()
        orderTotalLabel.Text = "Order Total:"
        orderTotalLabel.Location = New Point(10, 140)
        additionalFrame.Controls.Add(orderTotalLabel)
    End Sub

    Private Sub ClearForm(sender As Object, e As EventArgs)
        ' Implement the logic to clear the form
    End Sub

    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' PizzaOrderForm
        ' 
        ClientSize = New Size(1105, 662)
        Name = "PizzaOrderForm"

        ' Add the event handler directly using the Handles keyword
        AddHandler Me.Load, AddressOf PizzaOrderForm_Load

        ResumeLayout(False)
    End Sub

    Private Sub PizzaOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Pizza Order Form Loaded!")
    End Sub
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New PizzaOrderForm())
    End Sub
End Class
