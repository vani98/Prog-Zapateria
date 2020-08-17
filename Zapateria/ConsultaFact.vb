Public Class ConsultaFact

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub ConsultaFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.ZapateriaDataSet.Ventas)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim fila, contador, Total, filaConsulta As Integer
        Dim fecha1, fecha2 As String
        fecha1 = DateTimePicker1.Value.Date
        fecha2 = DateTimePicker2.Value.Date

        fila = 0 'ir bajando lineas en el datagrid
        Total = 0 'sumo los subtotales
        filaConsulta = 0 'para hacer la consulta de la otra tabla
        DataGridView1.Rows.Clear() 'limpio la grilla 
        VentasBindingSource.MoveFirst() 'muevo al primer registro de la tabla
        Do
            'no sirve si la fecha es nula el operador > o < por eso usamos is dbnull o isnotdbull

            If VentasBindingSource.Current("Fecha") IsNot DBNull.Value Then
                If VentasBindingSource.Current("Fecha") >= fecha1 And VentasBindingSource.Current("Fecha") <= fecha2 Then 'esta para texto

                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, fila).Value = VentasBindingSource.Current("ID_Cliente")
                    DataGridView1.Item(1, fila).Value = VentasBindingSource.Current("ID_Zap")
                    DataGridView1.Item(2, fila).Value = VentasBindingSource.Current("ID_Emp")
                    DataGridView1.Item(3, fila).Value = VentasBindingSource.Current("Fecha")
                    DataGridView1.Item(4, fila).Value = VentasBindingSource.Current("CantidadVend")
                    DataGridView1.Item(3, fila).Value = VentasBindingSource.Current("Tot_Fac")
                    Total = Total + VentasBindingSource.Current("Tot_Fac")
                    fila = fila + 1 'para ir bajando lineas en la grilla
                End If
            End If

            contador = contador + 1
            VentasBindingSource.MoveNext()
        Loop Until contador = VentasBindingSource.Count
        If fila = 0 Then

        Else
            'creo una fila final con el total a facturar
            DataGridView1.Item(4, fila).Value = "Total facturado"
            DataGridView1.Item(5, fila).Value = Total
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fila, contador, Total, filaConsulta As Integer
        Dim fecha1, fecha2 As String
        fecha1 = DateTimePicker1.Value.Date
        fecha2 = DateTimePicker2.Value.Date

        fila = 0 'ir bajando lineas en el datagrid
        Total = 0 'sumo los subtotales
        filaConsulta = 0 'para hacer la consulta de la otra tabla
        DataGridView1.Rows.Clear() 'limpio la grilla 
        VentasBindingSource.MoveFirst() 'muevo al primer registro de la tabla

        Do
            'no sirve si la fecha es nula el operador > o < por eso usamos is dbnull o isnotdbull

            If VentasBindingSource.Current("Fecha") IsNot DBNull.Value Then
                If VentasBindingSource.Current("Fecha") >= fecha1 And VentasBindingSource.Current("Fecha") <= fecha2 Then 'esta para texto

                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, fila).Value = VentasBindingSource.Current("ID_Cliente")
                    DataGridView1.Item(1, fila).Value = VentasBindingSource.Current("ID_Zap")
                    DataGridView1.Item(2, fila).Value = VentasBindingSource.Current("ID_Emp")
                    DataGridView1.Item(3, fila).Value = VentasBindingSource.Current("Fecha")
                    DataGridView1.Item(4, fila).Value = VentasBindingSource.Current("CantidadVend")
                    DataGridView1.Item(3, fila).Value = VentasBindingSource.Current("Tot_Fac")
                    Total = Total + VentasBindingSource.Current("Tot_Fac")
                    fila = fila + 1 'para ir bajando lineas en la grilla
                End If
            End If

            contador = contador + 1
            VentasBindingSource.MoveNext()
        Loop Until contador = VentasBindingSource.Count
        If fila = 0 Then

        Else
            'creo una fila final con el total a facturar
            DataGridView1.Item(4, fila).Value = "Total facturado"
            DataGridView1.Item(5, fila).Value = Total
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim fila, contador, Total, filaConsulta As Integer
        Dim fecha1, fecha2 As Date
        fecha1 = DateTimePicker1.Value.Date
        fecha2 = DateTimePicker2.Value.Date

        fila = 0 'ir bajando lineas en el datagrid
        Total = 0 'sumo los subtotales
        filaConsulta = 0 'para hacer la consulta de la otra tabla
        DataGridView1.Rows.Clear() 'limpio la grilla 
        VentasBindingSource.MoveFirst() 'muevo al primer registro de la tabla
        Do
            If VentasBindingSource.Current("Fecha") IsNot DBNull.Value Then

                If VentasBindingSource.Current("Fecha") >= fecha1 And VentasBindingSource.Current("Fecha") <= fecha2 And VentasBindingSource.Current("ID_Cliente") = Val(TextBox1.Text) Then 'esta para texto
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, fila).Value = VentasBindingSource.Current("ID_Cliente")
                    DataGridView1.Item(1, fila).Value = VentasBindingSource.Current("ID_Zap")
                    DataGridView1.Item(2, fila).Value = VentasBindingSource.Current("ID_Emp")
                    DataGridView1.Item(3, fila).Value = VentasBindingSource.Current("Fecha")
                    DataGridView1.Item(4, fila).Value = VentasBindingSource.Current("CantidadVend")
                    DataGridView1.Item(3, fila).Value = VentasBindingSource.Current("Tot_Fac")
                    Total = Total + VentasBindingSource.Current("Tot_Fac")
                    fila = fila + 1 'para ir bajando lineas en la grilla
                End If
            End If

            contador = contador + 1
            VentasBindingSource.MoveNext()
        Loop Until contador = VentasBindingSource.Count
        If fila = 0 Then

        Else
            'creo una fila final con el total a facturar
            DataGridView1.Item(2, fila).Value = "Total facturado"
            DataGridView1.Item(3, fila).Value = Total
        End If
    End Sub
End Class