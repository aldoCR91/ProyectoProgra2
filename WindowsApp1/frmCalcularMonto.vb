Imports System.IO
Imports Controlador
Public Class frmCalcularMonto
    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        Try
            'validar que no queden campos sin llenar al darle click en el btnCalcular

            If (txtMontoPrestamo.Text.Trim.Length = 0 Or txtMeses.Text.Length = 0 Or cboTipoPrestamo.SelectedIndex = 0 Or cboTipoMoneda.SelectedIndex = 0) Then

                Throw New Exception("No deben de quedar campos sin llenar.")

            End If


            Dim tipoPrestamo As String = cboTipoPrestamo.SelectedItem.ToString ' obtengo lo que el usuario selecciono en el combo box llamado cboTipoPrestamo
            Dim tipoMoneda As String = cboTipoMoneda.SelectedItem.ToString  ' obtengo lo que el usuario selecciono en el combo box llamado cboTipoPrestamo
            Dim calculos As New Calculos ' creo un objeto de la clase Calculos de capa negocios llamada BLL

            'Pregunto que tipo de moneda y prestamo selecciono el usuario para poder asignar la tasa de interes que tendra el prestamo
            If (tipoPrestamo = "Hipotecario") Then

                If (tipoMoneda = "Dolares") Then

                    calculos.tasa = CambioIntereses.hipotecaDolares / 100 / 12
                    ' asigno a la propiedad tasaInteres lo que tenga la variable del modolu llamado CambioIntereses y asi con las demas opciones de abajo

                Else

                    calculos.tasa = CambioIntereses.hipotecaColones / 100 / 12

                End If

            ElseIf (tipoPrestamo = "Compra de Auto") Then

                If (tipoMoneda = "Dolares") Then

                    calculos.tasa = CambioIntereses.autosDolares / 100 / 12

                Else

                    calculos.tasa = CambioIntereses.autosColones / 100 / 12

            End If

            Else

            If (tipoMoneda = "Dolares") Then

                    calculos.tasa = CambioIntereses.personalDolares / 100 / 12

                Else

                    calculos.tasa = CambioIntereses.personalColones / 100 / 12

                End If

            End If

            AlmacenaDatosPantalla.tipoPrestamo = tipoPrestamo ' asigno a la variable del modulo llamado  AlmacenaDatosPantalla el tipo de prestamo que selecciono el usuario

            ' nota: se utilizaron modulos porque nos permite usar las variables del modulo durante toda la ejecucion del programa, por ende nos permite utilizar estas variables en otras pantallas diferentes.

            Dim cuotaMensual As Double = 0

            With calculos

                ' al objeto de la clase calculos, le pasamos el contenido de los texbox a las propiedades de la clase llamada calculos
                calculos.meses = CInt(txtMeses.Text)
                calculos.montoPrestamo = CDec(txtMontoPrestamo.Text)
                cuotaMensual = calculos.calcularCuota() ' invocamos la funcion calculoCuota para realizar el calculo de la cuota del prestamo
                Dim strFormatDecimal As String = "#,##0.00;-#,##0.00" ' formato que permite separar los numeros en miles.
                txtMostrarCuota.Text = cuotaMensual.ToString(strFormatDecimal) ' asigno a txtMostrarCuota, la cuotaMensual para que el usuario vea en pantalla la cuota mensual del prestamo

                ' asigno a las variables del modulo AlmacenaDatosPantalla informacion, para poder reutilizar esa informacion desde otras pantallas
                AlmacenaDatosPantalla.cantMeses = CInt(txtMeses.Text)
                AlmacenaDatosPantalla.montoPrestamo = CDec(txtMontoPrestamo.Text)
                AlmacenaDatosPantalla.tasaIntereses = CDbl(calculos.tasa)
                AlmacenaDatosPantalla.cuotaMensualFija = cuotaMensual

            End With

            btnGenerarAmortizacion.Enabled = True ' habilito el boton de generarAmortizacion para que el usuario pueda ver la tabla de amortizacion
            '.Enabled = True ' habilito el boton de limpiar para que el usuario pueda volver a introducir todos los datos de nuevo
            btCalcular.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub ButtonVerTabla_Click(sender As Object, e As EventArgs) Handles btnGenerarAmortizacion.Click
        Me.Hide()
        Dim PantallaAmortizacion As New frmCalcularMonto
        PantallaAmortizacion.ShowDialog()
    End Sub

    Private Sub cboTipoPrestamo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPrestamo.SelectedIndexChanged

    End Sub

    Private Sub frmCalcularMonto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            With Me.cboTipoPrestamo.Items

                .Add("Seleccione.....")
                .Add("Hipotecario")
                .Add("Personal")
                .Add("Compra de Auto")

            End With

            cboTipoPrestamo.SelectedIndex = 0

            With Me.cboTipoMoneda.Items

                .Add("Seleccione.....")
                .Add("Colones")
                .Add("Dolares")

            End With

            cboTipoMoneda.SelectedIndex = 0
            btnGenerarAmortizacion.Enabled = False

            CambioIntereses.hipotecaColones = 8
            CambioIntereses.hipotecaDolares = 6
            CambioIntereses.autosColones = 7
            CambioIntereses.autosDolares = 5
            CambioIntereses.personalColones = 18
            CambioIntereses.personalDolares = 15


        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try

    End Sub

    Private Sub DataGridViewTabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTabla.CellContentClick

    End Sub
    'End Sub
End Class