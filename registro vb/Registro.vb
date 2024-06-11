Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports System.IO
Imports Newtonsoft.Json
Imports Xceed.Words.NET
Imports Microsoft.Office.Interop.Excel
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports Document = iTextSharp.text.Document
Imports Formatting = Newtonsoft.Json.Formatting
Imports System.Diagnostics
Imports Table = Xceed.Document.NET.Table

Namespace registro_de_trabajador
    Public Partial Class Registro
        Inherits Form
        Public Sub New()

            InitializeComponent()

        End Sub

        Private Sub Nombretext_KeyPress(sender As Object, e As KeyPressEventArgs)
            ' Verifica si la tecla presionada es un número
            If Char.IsDigit(e.KeyChar) Then
                ' Cancela el evento si es un número
                e.Handled = True
            End If

        End Sub

        Private Sub apellidotext_KeyPress(sender As Object, e As KeyPressEventArgs)
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If

        End Sub

        Private Sub apellidomtext_KeyPress(sender As Object, e As KeyPressEventArgs)
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End Sub

        Private Sub edadtext_KeyPress(sender As Object, e As KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If

        End Sub

        Private Sub phonetext_KeyPress(sender As Object, e As KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs)
            Dim datosp As registro_de_trabajador.Datos_de_persona = New registro_de_trabajador.Datos_de_persona()
            datosp.Nombre = Nombretext.Text
            datosp.ApellidoPaterno = apellidotext.Text
            datosp.Apellidomaterno = apellidomtext.Text
            datosp.Cumple = dateTimePicker1.Value
            datosp.Edad = edadtext.Text

            Dim datosr As registro_de_trabajador.Datos_de_registro = New registro_de_trabajador.Datos_de_registro()
            datosr.Curp = curptext.Text
            datosr.Rfc = rfctext.Text
            datosr.Correo = emailtext.Text
            datosr.Phone = phonetext.Text

            Dim load As DataGridViewRow = New DataGridViewRow()
            load.CreateCells(Datosdetrabajadores)
            load.Cells(0).Value = Nombretext.Text
            load.Cells(1).Value = apellidotext.Text
            load.Cells(2).Value = apellidomtext.Text
            load.Cells(3).Value = dateTimePicker1.Text
            load.Cells(4).Value = edadtext.Text
            load.Cells(5).Value = curptext.Text
            load.Cells(6).Value = rfctext.Text
            load.Cells(7).Value = emailtext.Text
            load.Cells(8).Value = phonetext.Text
            load.Cells(9).Value = comboBox1.Text
            load.Cells(10).Value = comboBox2.Text
            load.Cells(11).Value = Single.Parse(label13.Text) * Single.Parse(label14.Text)
            Datosdetrabajadores.Rows.Add(load)
            Nombretext.Text = CSharpImpl.__Assign(apellidotext.Text, CSharpImpl.__Assign(apellidomtext.Text, CSharpImpl.__Assign(dateTimePicker1.Text, CSharpImpl.__Assign(edadtext.Text, CSharpImpl.__Assign(curptext.Text, CSharpImpl.__Assign(rfctext.Text, CSharpImpl.__Assign(emailtext.Text, CSharpImpl.__Assign(phonetext.Text, CSharpImpl.__Assign(comboBox1.Text, CSharpImpl.__Assign(comboBox2.Text, ""))))))))))

        End Sub

        Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
            Dim sueldo As Single
            sueldo = comboBox1.SelectedIndex

            Select Case sueldo
                Case 0
                    label13.Text = "100"
                Case 1
                    label13.Text = "90"
                Case Else
                    label13.Text = "80"

            End Select
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
            Dim Horas As Single
            Horas = comboBox2.SelectedIndex
            Select Case Horas
                Case 0
                    label14.Text = "2"
                Case 1
                    label14.Text = "3"
                Case 2
                    label14.Text = "4"
                Case 3
                    label14.Text = "5"
                Case 4
                    label14.Text = "6"
                Case 5
                    label14.Text = "7"
                Case Else
                    label14.Text = "8"
            End Select
        End Sub


        Private Sub Registro_Load(sender As Object, e As EventArgs)

            Dim filePath = "C:\Users\volub\source\repos\registro-de-trabajador1\Trabajadores\documento.txt"


            If File.Exists(filePath) Then
                Try
                    ' Leer el archivo y cargar los datos en el DataGridView
                    Using reader As StreamReader = New StreamReader(filePath)
                        Dim line As String
                        While Not Equals((CSharpImpl.__Assign(line, reader.ReadLine())), Nothing)
                            Datosdetrabajadores.Rows.Add(line.Split(ChrW(9)))
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al leer el archivo: " & ex.Message)
                End Try
            Else
                MessageBox.Show("El archivo no existe.")
            End If
        End Sub

        Private Sub button4_Click(sender As Object, e As EventArgs)

            Dim filePath = "C:\Users\volub\source\repos\registro-de-trabajador1\Trabajadores\documento.txt"

            Using writer As StreamWriter = New StreamWriter(filePath)
                For Each row As DataGridViewRow In Datosdetrabajadores.Rows
                    If Not row.IsNewRow Then
                        Dim line As String = String.Join(vbTab, row.Cells.Cast(Of DataGridViewCell)().[Select](Function(cell) If(cell.Value?.ToString(), "")).ToArray())
                        writer.WriteLine(line)
                    End If
                Next
            End Using

            MessageBox.Show("Datos guardados correctamente.")
        End Sub

        Private Sub borrarbtn_Click(sender As Object, e As EventArgs)
            Try
                Dim rppta = MessageBox.Show("¿Eliminar empleado", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If rppta = DialogResult.Yes Then
                    Datosdetrabajadores.Rows.Remove(Datosdetrabajadores.CurrentRow)

                End If

            Catch
            End Try
        End Sub

        Private Sub button5_Click(sender As Object, e As EventArgs)
            Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo Excel (*.xlsx)|*.xlsx|Archivo PDF (*.pdf)|*.pdf|Documento de World (*.docx)|*.docx|Archivos json (*.json)|*.json"
            saveFileDialog1.Title = "Guardar como archivo"
            saveFileDialog1.ShowDialog()

            ' Si se selecciona un archivo y se confirma la selección
            If Not Equals(saveFileDialog1.FileName, "") Then
                Try
                    Dim fileName = saveFileDialog1.FileName

                    If saveFileDialog1.FilterIndex = 1 Then
                        ExportarAExcel(fileName)

                    ElseIf saveFileDialog1.FilterIndex = 2 Then
                        ExportarAPDF(fileName)
                    ElseIf saveFileDialog1.FilterIndex = 3 Then
                        ExportarAWord(fileName)
                    ElseIf saveFileDialog1.FilterIndex = 4 Then
                        ExportarAPDF(fileName)
                    End If


                    MessageBox.Show("Los datos se exportaron correctamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al exportar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub



        Private Sub ExportarAExcel(fileName As String)
            Dim excelApp As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()

            ' Crea un nuevo libro de Excel
            Dim workbook As Workbook = excelApp.Workbooks.Add()

            ' Obtiene la primera hoja de trabajo del libro
            Dim worksheet = CType(workbook.Sheets(1), Worksheet)

            ' Escribe los datos del DataGridView en la hoja de trabajo
            For i = 0 To Datosdetrabajadores.Columns.Count - 1
                worksheet.Cells(1, i + 1) = Datosdetrabajadores.Columns(i).HeaderText
            Next

            For i = 0 To Datosdetrabajadores.Rows.Count - 1
                For j = 0 To Datosdetrabajadores.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1) = Datosdetrabajadores.Rows(i).Cells(j).Value
                Next
            Next

            ' Guarda el libro en un archivo
            workbook.SaveAs(fileName)

            ' Cierra el libro y Excel
            workbook.Close()
            excelApp.Quit()
            Call Process.Start(New ProcessStartInfo(fileName) With {
                .UseShellExecute = True
            })
        End Sub



        Private Sub ExportarAPDF(fileName As String)

            ' Crear un nuevo documento PDF
            Dim doc As Document = New Document()

            ' Crear un objeto PdfWriter para escribir en el archivo PDF
            Call PdfWriter.GetInstance(doc, New FileStream(fileName, FileMode.Create))

            ' Abrir el documento para escribir en él
            doc.Open()

            ' Agregar un párrafo al documento
            Dim paragraph As iTextSharp.text.Paragraph = New iTextSharp.text.Paragraph("Datos exportados desde DataGridView:")
            doc.Add(paragraph)

            ' Crear una tabla con el mismo número de columnas que el DataGridView
            Dim table As PdfPTable = New PdfPTable(Datosdetrabajadores.Columns.Count)

            ' Agregar encabezados de columnas a la tabla
            For i = 0 To Datosdetrabajadores.Columns.Count - 1
                table.AddCell(New Phrase(Datosdetrabajadores.Columns(i).HeaderText))
            Next

            ' Agregar datos de celdas a la tabla
            For i = 0 To Datosdetrabajadores.Rows.Count - 1
                For j = 0 To Datosdetrabajadores.Columns.Count - 1
                    If Datosdetrabajadores.Rows(i).Cells(j).Value IsNot Nothing Then
                        table.AddCell(New Phrase(Datosdetrabajadores.Rows(i).Cells(j).Value.ToString()))
                    Else
                        table.AddCell(New Phrase(""))
                    End If
                Next
            Next

            ' Agregar la tabla al documento
            doc.Add(table)
            doc.Close()
            Call Process.Start(New ProcessStartInfo(fileName) With {
                .UseShellExecute = True
            })

        End Sub
        Private Sub ExportarAWord(filename As String)
            Using document = DocX.Create(filename)
                ' Crear una tabla con el mismo número de columnas que el DataGridView
                Dim table = document.AddTable(Datosdetrabajadores.Rows.Count + 1, Datosdetrabajadores.Columns.Count)

                ' Agregar encabezados de columnas a la tabla
                For i = 0 To Datosdetrabajadores.Columns.Count - 1
                    Enumerable.First(table.Rows(0).Cells(i).Paragraphs).Append(Datosdetrabajadores.Columns(i).HeaderText)
                Next

                ' Agregar datos de celdas a la tabla
                For i = 0 To Datosdetrabajadores.Rows.Count - 1
                    For j = 0 To Datosdetrabajadores.Columns.Count - 1
                        Dim valueString As String = If(Datosdetrabajadores.Rows(i).Cells(j).Value?.ToString(), "")
                        Enumerable.First(table.Rows(i + 1).Cells(j).Paragraphs).Append(valueString)
                    Next
                Next

                ' Insertar la tabla en el documento
                document.InsertTable(table)

                ' Guardar el documento
                document.Save()
                Call Process.Start(New ProcessStartInfo(filename) With {
                    .UseShellExecute = True
                })
            End Using
        End Sub

        Private Sub ExportarAJSON(filename As String)
            Dim datos As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()

            ' Recorrer las filas y columnas del DataGridView y agregar los datos a la lista
            For Each fila As DataGridViewRow In Datosdetrabajadores.Rows
                Dim filaDict As Dictionary(Of String, Object) = New Dictionary(Of String, Object)()
                For Each columna As DataGridViewColumn In Datosdetrabajadores.Columns
                    filaDict(columna.Name) = fila.Cells(columna.Index).Value
                Next
                datos.Add(filaDict)
            Next

            ' Convertir la lista de datos a formato JSON
            Dim json = JsonConvert.SerializeObject(datos, Formatting.Indented)

            ' Guardar el JSON en un archivo
            File.WriteAllText(filename, json)

            Call Process.Start(New ProcessStartInfo(filename) With {
                .UseShellExecute = True
            })

        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class


    End Class

End Namespace
