﻿Public Class Alta_Producto

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub Alta_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ZapateriaDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'ZapateriaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        ' Me.MarcasBindingSource.AddNew()
        Me.ProductosBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedValue = Nothing Then
            MsgBox("Elija una marca")
            Exit Sub
        End If

        If ComboBox2.SelectedValue = Nothing Then
            MsgBox("Elija un proveedor")
            Exit Sub
        End If

        If PrecioTextBox.Text = Nothing Then
            MsgBox("Ingrese el precio")
            Exit Sub
        End If
        If StockTextBox.Text = Nothing Then
            MsgBox("Ingrese el stock")
            Exit Sub
        End If
        If PrecioTextBox.Text = Nothing Then
            MsgBox("Ingrese el modelo")
            Exit Sub
        End If

        Me.ProductosBindingSource.Current("ID_Marca") = ComboBox1.SelectedValue
        Me.ProductosBindingSource.Current("ID_Proveedor") = ComboBox2.SelectedValue
        Me.ProductosBindingSource.Current("Modelo") = ModeloTextBox.Text
        Me.ProductosBindingSource.Current("Talla") = Val(TallaTextBox.Text)
        Me.ProductosBindingSource.Current("Precio") = Val(PrecioTextBox.Text)
        Me.ProductosBindingSource.Current("Color") = ColorTextBox.Text
        Me.ProductosBindingSource.Current("Estilo") = EstiloTextBox.Text
        Me.ProductosBindingSource.Current("Stock") = Val(StockTextBox.Text)

        Me.ProductosBindingSource.EndEdit()
        ' Me.MarcasBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)
        Me.ProductosTableAdapter.Fill(Me.ZapateriaDataSet.Productos)
        ' Me.MarcasTableAdapter.Fill(Me.ZapateriaDataSet.Marcas)

        Principal_Producto.ProductosTableAdapter.Fill(Principal_Producto.ZapateriaDataSet.Productos)
        Buscar_Productos.ProductosTableAdapter.Fill(Buscar_Productos.ZapateriaDataSet.Productos)

        ' Principal_Producto.MarcasTableAdapter.Fill(Principal_Producto.ZapateriaDataSet.Marcas)
        Me.ProductosBindingSource.MoveLast() 'muestra el ultimo agregado
        MsgBox("El ID del producto es:" + Me.ProductosBindingSource.Current("ID_Zap").ToString)
        Me.ProductosBindingSource.AddNew()
        'Me.MarcasBindingSource.AddNew()

    End Sub

    Private Sub Alta_Producto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.Escape Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AltaMarca.Show()

    End Sub

    Private Sub TallaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallaTextBox.TextChanged

    End Sub

    Private Sub PrecioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioTextBox.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AltasProv.Show()
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ZapateriaDataSet)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ColorTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ColorTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub EstiloTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EstiloTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten números")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub TallaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TallaTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If

    End Sub

    Private Sub PrecioTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioTextBox.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub

    Private Sub StockTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StockTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permiten letras")
            sender.focus()
            sender.selectall()
        End If
    End Sub
End Class