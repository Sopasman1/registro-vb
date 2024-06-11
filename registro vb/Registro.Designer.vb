Namespace registro_de_trabajador
    Partial Class Registro
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
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
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            panel1 = New System.Windows.Forms.Panel()
            Salvardatos = New System.Windows.Forms.Button()
            label14 = New System.Windows.Forms.Label()
            label13 = New System.Windows.Forms.Label()
            label12 = New System.Windows.Forms.Label()
            label11 = New System.Windows.Forms.Label()
            label10 = New System.Windows.Forms.Label()
            label5 = New System.Windows.Forms.Label()
            label9 = New System.Windows.Forms.Label()
            label8 = New System.Windows.Forms.Label()
            label7 = New System.Windows.Forms.Label()
            label6 = New System.Windows.Forms.Label()
            label4 = New System.Windows.Forms.Label()
            label3 = New System.Windows.Forms.Label()
            label2 = New System.Windows.Forms.Label()
            label1 = New System.Windows.Forms.Label()
            comboBox2 = New System.Windows.Forms.ComboBox()
            comboBox1 = New System.Windows.Forms.ComboBox()
            button1 = New System.Windows.Forms.Button()
            dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            edadtext = New System.Windows.Forms.TextBox()
            phonetext = New System.Windows.Forms.TextBox()
            emailtext = New System.Windows.Forms.TextBox()
            rfctext = New System.Windows.Forms.TextBox()
            curptext = New System.Windows.Forms.TextBox()
            apellidomtext = New System.Windows.Forms.TextBox()
            apellidotext = New System.Windows.Forms.TextBox()
            Nombretext = New System.Windows.Forms.TextBox()
            panel2 = New System.Windows.Forms.Panel()
            Datosdetrabajadores = New System.Windows.Forms.DataGridView()
            Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            panel3 = New System.Windows.Forms.Panel()
            button5 = New System.Windows.Forms.Button()
            borrarbtn = New System.Windows.Forms.Button()
            panel1.SuspendLayout()
            panel2.SuspendLayout()
            CType(Datosdetrabajadores, ComponentModel.ISupportInitialize).BeginInit()
            panel3.SuspendLayout()
            SuspendLayout()
            ' 
            ' panel1
            ' 
            panel1.BackColor = Drawing.Color.MediumTurquoise
            panel1.Controls.Add(Salvardatos)
            panel1.Controls.Add(label14)
            panel1.Controls.Add(label13)
            panel1.Controls.Add(label12)
            panel1.Controls.Add(label11)
            panel1.Controls.Add(label10)
            panel1.Controls.Add(label5)
            panel1.Controls.Add(label9)
            panel1.Controls.Add(label8)
            panel1.Controls.Add(label7)
            panel1.Controls.Add(label6)
            panel1.Controls.Add(label4)
            panel1.Controls.Add(label3)
            panel1.Controls.Add(label2)
            panel1.Controls.Add(label1)
            panel1.Controls.Add(comboBox2)
            panel1.Controls.Add(comboBox1)
            panel1.Controls.Add(button1)
            panel1.Controls.Add(dateTimePicker1)
            panel1.Controls.Add(edadtext)
            panel1.Controls.Add(phonetext)
            panel1.Controls.Add(emailtext)
            panel1.Controls.Add(rfctext)
            panel1.Controls.Add(curptext)
            panel1.Controls.Add(apellidomtext)
            panel1.Controls.Add(apellidotext)
            panel1.Controls.Add(Nombretext)
            panel1.Dock = System.Windows.Forms.DockStyle.Left
            panel1.Location = New Drawing.Point(0, 0)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(392, 537)
            panel1.TabIndex = 0
            ' 
            ' Salvardatos
            ' 
            Salvardatos.Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            Salvardatos.Location = New Drawing.Point(311, 502)
            Salvardatos.Name = "Salvardatos"
            Salvardatos.Size = New Drawing.Size(75, 23)
            Salvardatos.TabIndex = 15
            Salvardatos.Text = "save data"
            Salvardatos.UseVisualStyleBackColor = True
            AddHandler Salvardatos.Click, AddressOf button4_Click
            ' 
            ' label14
            ' 
            label14.AutoSize = True
            label14.ForeColor = Drawing.Color.MediumTurquoise
            label14.Location = New Drawing.Point(260, 374)
            label14.Name = "label14"
            label14.Size = New Drawing.Size(44, 15)
            label14.TabIndex = 28
            label14.Text = "label14"
            ' 
            ' label13
            ' 
            label13.AutoSize = True
            label13.ForeColor = Drawing.Color.MediumTurquoise
            label13.Location = New Drawing.Point(12, 374)
            label13.Name = "label13"
            label13.Size = New Drawing.Size(44, 15)
            label13.TabIndex = 27
            label13.Text = "label13"
            ' 
            ' label12
            ' 
            label12.AutoSize = True
            label12.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label12.Location = New Drawing.Point(274, 330)
            label12.Name = "label12"
            label12.Size = New Drawing.Size(95, 15)
            label12.TabIndex = 26
            label12.Text = "Hours Worked"
            ' 
            ' label11
            ' 
            label11.AutoSize = True
            label11.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label11.Location = New Drawing.Point(58, 330)
            label11.Name = "label11"
            label11.Size = New Drawing.Size(29, 15)
            label11.TabIndex = 25
            label11.Text = "Job"
            ' 
            ' label10
            ' 
            label10.AutoSize = True
            label10.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label10.Location = New Drawing.Point(260, 196)
            label10.Name = "label10"
            label10.Size = New Drawing.Size(97, 15)
            label10.TabIndex = 24
            label10.Text = "Phone Number"
            ' 
            ' label5
            ' 
            label5.AutoSize = True
            label5.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label5.Location = New Drawing.Point(71, 257)
            label5.Name = "label5"
            label5.Size = New Drawing.Size(31, 15)
            label5.TabIndex = 23
            label5.Text = "Age"
            ' 
            ' label9
            ' 
            label9.AutoSize = True
            label9.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label9.Location = New Drawing.Point(287, 82)
            label9.Name = "label9"
            label9.Size = New Drawing.Size(29, 15)
            label9.TabIndex = 22
            label9.Text = "RFC"
            ' 
            ' label8
            ' 
            label8.AutoSize = True
            label8.Location = New Drawing.Point(287, 196)
            label8.Name = "label8"
            label8.Size = New Drawing.Size(0, 15)
            label8.TabIndex = 21
            ' 
            ' label7
            ' 
            label7.AutoSize = True
            label7.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label7.Location = New Drawing.Point(283, 141)
            label7.Name = "label7"
            label7.Size = New Drawing.Size(40, 15)
            label7.TabIndex = 20
            label7.Text = "Email"
            ' 
            ' label6
            ' 
            label6.AutoSize = True
            label6.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label6.Location = New Drawing.Point(283, 21)
            label6.Name = "label6"
            label6.Size = New Drawing.Size(40, 15)
            label6.TabIndex = 18
            label6.Text = "CURP"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label4.Location = New Drawing.Point(44, 196)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(89, 15)
            label4.TabIndex = 17
            label4.Text = "Birthday Date"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label3.Location = New Drawing.Point(31, 141)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(116, 15)
            label3.TabIndex = 16
            label3.Text = "Mother Last Name"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label2.Location = New Drawing.Point(57, 82)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(69, 15)
            label2.TabIndex = 15
            label2.Text = "Last Name"
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Segoe UI Black", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.Location = New Drawing.Point(70, 21)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(42, 15)
            label1.TabIndex = 14
            label1.Text = "Name"
            ' 
            ' comboBox2
            ' 
            comboBox2.FormattingEnabled = True
            comboBox2.Items.AddRange(New Object() {"2 hora", "3 hora", "4 hora", "5 hora", "6 hora", "7 hora", "8 hora"})
            comboBox2.Location = New Drawing.Point(260, 348)
            comboBox2.Name = "comboBox2"
            comboBox2.Size = New Drawing.Size(121, 23)
            comboBox2.TabIndex = 11
            AddHandler comboBox2.SelectedIndexChanged, AddressOf comboBox2_SelectedIndexChanged
            ' 
            ' comboBox1
            ' 
            comboBox1.FormattingEnabled = True
            comboBox1.Items.AddRange(New Object() {"Gerentes", "Supervisor", "Operarios"})
            comboBox1.Location = New Drawing.Point(12, 348)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(121, 23)
            comboBox1.TabIndex = 10
            AddHandler comboBox1.SelectedIndexChanged, AddressOf comboBox1_SelectedIndexChanged
            ' 
            ' button1
            ' 
            button1.Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button1.Location = New Drawing.Point(12, 502)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(90, 23)
            button1.TabIndex = 9
            button1.Text = "Save to list"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, AddressOf button1_Click
            ' 
            ' dateTimePicker1
            ' 
            dateTimePicker1.Location = New Drawing.Point(12, 214)
            dateTimePicker1.Name = "dateTimePicker1"
            dateTimePicker1.Size = New Drawing.Size(154, 23)
            dateTimePicker1.TabIndex = 8
            ' 
            ' edadtext
            ' 
            edadtext.Location = New Drawing.Point(12, 275)
            edadtext.Name = "edadtext"
            edadtext.Size = New Drawing.Size(154, 23)
            edadtext.TabIndex = 7
            AddHandler edadtext.KeyPress, AddressOf edadtext_KeyPress
            ' 
            ' phonetext
            ' 
            phonetext.Location = New Drawing.Point(227, 214)
            phonetext.Name = "phonetext"
            phonetext.Size = New Drawing.Size(154, 23)
            phonetext.TabIndex = 6
            AddHandler phonetext.KeyPress, AddressOf phonetext_KeyPress
            ' 
            ' emailtext
            ' 
            emailtext.Location = New Drawing.Point(227, 159)
            emailtext.Name = "emailtext"
            emailtext.Size = New Drawing.Size(154, 23)
            emailtext.TabIndex = 5
            ' 
            ' rfctext
            ' 
            rfctext.Location = New Drawing.Point(227, 100)
            rfctext.Name = "rfctext"
            rfctext.Size = New Drawing.Size(154, 23)
            rfctext.TabIndex = 4
            ' 
            ' curptext
            ' 
            curptext.Location = New Drawing.Point(227, 39)
            curptext.Name = "curptext"
            curptext.Size = New Drawing.Size(154, 23)
            curptext.TabIndex = 3
            ' 
            ' apellidomtext
            ' 
            apellidomtext.Location = New Drawing.Point(12, 159)
            apellidomtext.Name = "apellidomtext"
            apellidomtext.Size = New Drawing.Size(154, 23)
            apellidomtext.TabIndex = 2
            AddHandler apellidomtext.KeyPress, AddressOf apellidomtext_KeyPress
            ' 
            ' apellidotext
            ' 
            apellidotext.Location = New Drawing.Point(12, 100)
            apellidotext.Name = "apellidotext"
            apellidotext.Size = New Drawing.Size(154, 23)
            apellidotext.TabIndex = 1
            AddHandler apellidotext.KeyPress, AddressOf apellidotext_KeyPress
            ' 
            ' Nombretext
            ' 
            Nombretext.Location = New Drawing.Point(12, 39)
            Nombretext.Name = "Nombretext"
            Nombretext.Size = New Drawing.Size(154, 23)
            Nombretext.TabIndex = 0
            AddHandler Nombretext.KeyPress, AddressOf Nombretext_KeyPress
            ' 
            ' panel2
            ' 
            panel2.Controls.Add(Datosdetrabajadores)
            panel2.Dock = System.Windows.Forms.DockStyle.Top
            panel2.Location = New Drawing.Point(392, 0)
            panel2.Name = "panel2"
            panel2.Size = New Drawing.Size(910, 429)
            panel2.TabIndex = 1
            ' 
            ' Datosdetrabajadores
            ' 
            Datosdetrabajadores.AllowUserToOrderColumns = True
            Datosdetrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Datosdetrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
            Datosdetrabajadores.Dock = System.Windows.Forms.DockStyle.Fill
            Datosdetrabajadores.Location = New Drawing.Point(0, 0)
            Datosdetrabajadores.Name = "Datosdetrabajadores"
            Datosdetrabajadores.Size = New Drawing.Size(910, 429)
            Datosdetrabajadores.TabIndex = 0
            ' 
            ' Column1
            ' 
            Column1.HeaderText = "Name"
            Column1.Name = "Column1"
            ' 
            ' Column2
            ' 
            Column2.HeaderText = "Last Name"
            Column2.Name = "Column2"
            ' 
            ' Column3
            ' 
            Column3.HeaderText = "Mother Last Name"
            Column3.Name = "Column3"
            ' 
            ' Column4
            ' 
            Column4.HeaderText = "Birthday Date"
            Column4.Name = "Column4"
            ' 
            ' Column5
            ' 
            Column5.HeaderText = "Age"
            Column5.Name = "Column5"
            ' 
            ' Column6
            ' 
            Column6.HeaderText = "CURP"
            Column6.Name = "Column6"
            ' 
            ' Column7
            ' 
            Column7.HeaderText = "RFC"
            Column7.Name = "Column7"
            ' 
            ' Column8
            ' 
            Column8.HeaderText = "Email"
            Column8.Name = "Column8"
            ' 
            ' Column9
            ' 
            Column9.HeaderText = "Phone Number"
            Column9.Name = "Column9"
            ' 
            ' Column10
            ' 
            Column10.HeaderText = "Job"
            Column10.Name = "Column10"
            ' 
            ' Column11
            ' 
            Column11.HeaderText = "Hours Worked"
            Column11.Name = "Column11"
            ' 
            ' Column12
            ' 
            Column12.HeaderText = "Salary"
            Column12.Name = "Column12"
            ' 
            ' panel3
            ' 
            panel3.BackColor = Drawing.Color.Aquamarine
            panel3.Controls.Add(button5)
            panel3.Controls.Add(borrarbtn)
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            panel3.Location = New Drawing.Point(392, 429)
            panel3.Name = "panel3"
            panel3.Size = New Drawing.Size(910, 108)
            panel3.TabIndex = 2
            ' 
            ' button5
            ' 
            button5.Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button5.Location = New Drawing.Point(145, 45)
            button5.Name = "button5"
            button5.Size = New Drawing.Size(75, 23)
            button5.TabIndex = 15
            button5.Text = "Export"
            button5.UseVisualStyleBackColor = True
            AddHandler button5.Click, AddressOf button5_Click
            ' 
            ' borrarbtn
            ' 
            borrarbtn.Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            borrarbtn.Location = New Drawing.Point(6, 45)
            borrarbtn.Name = "borrarbtn"
            borrarbtn.Size = New Drawing.Size(103, 23)
            borrarbtn.TabIndex = 0
            borrarbtn.Text = "Delete worker"
            borrarbtn.UseVisualStyleBackColor = True
            AddHandler borrarbtn.Click, AddressOf borrarbtn_Click
            ' 
            ' Registro
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1302, 537)
            Controls.Add(panel3)
            Controls.Add(panel2)
            Controls.Add(panel1)
            Name = "Registro"
            Text = "Registro"
            AddHandler Load, AddressOf Registro_Load
            panel1.ResumeLayout(False)
            panel1.PerformLayout()
            panel2.ResumeLayout(False)
            CType(Datosdetrabajadores, ComponentModel.ISupportInitialize).EndInit()
            panel3.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

#End Region

        Private panel1 As System.Windows.Forms.Panel
        Private curptext As System.Windows.Forms.TextBox
        Private apellidomtext As System.Windows.Forms.TextBox
        Private apellidotext As System.Windows.Forms.TextBox
        Private Nombretext As System.Windows.Forms.TextBox
        Private comboBox2 As System.Windows.Forms.ComboBox
        Private comboBox1 As System.Windows.Forms.ComboBox
        Private button1 As System.Windows.Forms.Button
        Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
        Private edadtext As System.Windows.Forms.TextBox
        Private phonetext As System.Windows.Forms.TextBox
        Private emailtext As System.Windows.Forms.TextBox
        Private rfctext As System.Windows.Forms.TextBox
        Private label6 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label9 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private label12 As System.Windows.Forms.Label
        Private label11 As System.Windows.Forms.Label
        Private panel2 As System.Windows.Forms.Panel
        Private Datosdetrabajadores As System.Windows.Forms.DataGridView
        Private panel3 As System.Windows.Forms.Panel
        Private borrarbtn As System.Windows.Forms.Button
        Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private label14 As System.Windows.Forms.Label
        Private label13 As System.Windows.Forms.Label
        Private Salvardatos As System.Windows.Forms.Button
        Private button5 As System.Windows.Forms.Button
    End Class
End Namespace
