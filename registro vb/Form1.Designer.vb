Namespace registro_de_trabajador
    Partial Class Form1
        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            label1 = New System.Windows.Forms.Label()
            panel1 = New System.Windows.Forms.Panel()
            passwordtbox = New System.Windows.Forms.TextBox()
            label2 = New System.Windows.Forms.Label()
            label3 = New System.Windows.Forms.Label()
            Enterbtn = New System.Windows.Forms.Button()
            panel1.SuspendLayout()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Segoe UI", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(150, 10)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(210, 30)
            label1.TabIndex = 0
            label1.Text = "Worker Registration"
            ' 
            ' panel1
            ' 
            panel1.BackColor = Drawing.Color.MediumTurquoise
            panel1.Controls.Add(label1)
            panel1.Location = New Drawing.Point(-1, -1)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(504, 57)
            panel1.TabIndex = 1
            ' 
            ' passwordtbox
            ' 
            passwordtbox.Font = New Drawing.Font("Segoe UI", 20.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            passwordtbox.Location = New Drawing.Point(120, 112)
            passwordtbox.Multiline = True
            passwordtbox.Name = "passwordtbox"
            passwordtbox.Size = New Drawing.Size(265, 46)
            passwordtbox.TabIndex = 2
            AddHandler passwordtbox.KeyPress, AddressOf passwordtbox_KeyPress
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(233, 94)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 15)
            label2.TabIndex = 3
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Font = New Drawing.Font("Segoe UI", 9.75F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Underline, Drawing.GraphicsUnit.Point, 0)
            label3.Location = New Drawing.Point(204, 161)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(102, 17)
            label3.TabIndex = 4
            label3.Text = "Enter Password"
            ' 
            ' Enterbtn
            ' 
            Enterbtn.Location = New Drawing.Point(217, 236)
            Enterbtn.Name = "Enterbtn"
            Enterbtn.Size = New Drawing.Size(75, 23)
            Enterbtn.TabIndex = 5
            Enterbtn.Text = "Enter"
            Enterbtn.UseVisualStyleBackColor = True
            AddHandler Enterbtn.Click, AddressOf Enterbtn_Click
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(502, 271)
            Controls.Add(Enterbtn)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(passwordtbox)
            Controls.Add(panel1)
            Name = "Form1"
            Text = "Form1"
            panel1.ResumeLayout(False)
            panel1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Private label1 As System.Windows.Forms.Label
        Private panel1 As System.Windows.Forms.Panel
        Private passwordtbox As System.Windows.Forms.TextBox
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private Enterbtn As System.Windows.Forms.Button
    End Class
End Namespace
