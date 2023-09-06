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
        btnTotalforCustomer = New Button()
        txtTextBox1 = New TextBox()
        txtTextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtTextBox3 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnTotalforCustomer
        ' 
        btnTotalforCustomer.Location = New Point(259, 238)
        btnTotalforCustomer.Name = "btnTotalforCustomer"
        btnTotalforCustomer.Size = New Size(246, 77)
        btnTotalforCustomer.TabIndex = 0
        btnTotalforCustomer.Text = "Total For Customer"
        btnTotalforCustomer.UseVisualStyleBackColor = True
        ' 
        ' txtTextBox1
        ' 
        txtTextBox1.Location = New Point(359, 73)
        txtTextBox1.Name = "txtTextBox1"
        txtTextBox1.Size = New Size(150, 31)
        txtTextBox1.TabIndex = 1
        ' 
        ' txtTextBox2
        ' 
        txtTextBox2.Location = New Point(359, 132)
        txtTextBox2.Name = "txtTextBox2"
        txtTextBox2.Size = New Size(150, 31)
        txtTextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(221, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 25)
        Label1.TabIndex = 2
        Label1.Text = "Price per Item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(191, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 25)
        Label2.TabIndex = 2
        Label2.Text = "Quantity of Items"
        ' 
        ' txtTextBox3
        ' 
        txtTextBox3.Location = New Point(359, 180)
        txtTextBox3.Name = "txtTextBox3"
        txtTextBox3.Size = New Size(150, 31)
        txtTextBox3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(191, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 25)
        Label3.TabIndex = 4
        Label3.Text = "Customer Name"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(txtTextBox3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTextBox2)
        Controls.Add(txtTextBox1)
        Controls.Add(btnTotalforCustomer)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTotalforCustomer As Button
    Friend WithEvents txtTextBox1 As TextBox
    Friend WithEvents txtTextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTextBox3 As TextBox
    Friend WithEvents Label3 As Label
End Class
