
Public Class Calculos

    'Variables
    Private _monto As Decimal
    Private _meses As Integer
    Private _tasa As Double
    Private _cuota As Double
    Private _interes As Double
    Private _amortizacion As Double
    Private _saldo As Double

    'Propiedades

    'Public Property cuotas As Double



    'End Property
    Public Property cuota As Double
        Get
            Return _cuota
        End Get
        Set(ByVal value As Double)
            _cuota = value
        End Set
    End Property

    Public Property montoPrestamo As Decimal
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property

    Public Property meses As Integer
        Get
            Return _meses
        End Get
        Set(ByVal value As Integer)
            _meses = value
        End Set
    End Property

    Public Property tasa As Double
        Get
            Return _tasa
        End Get
        Set(ByVal value As Double)
            _tasa = value
        End Set
    End Property

    Public Property InteresMensual As Double
        Get
            Return _interes
        End Get
        Set(value As Double)
            _interes = value
        End Set
    End Property

    Public Property Amortizacion As Double
        Get
            Return _amortizacion
        End Get
        Set(value As Double)
            _amortizacion = value
        End Set
    End Property

    Public Property Saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property

    '  se validan  los datos de entrada de usuario

    Public Sub validarDatos()

        If (Me._monto <= 0) Then Throw New Exception("El monto prestamo debe ser mayor a cero")

        If (_meses <= 0) Then Throw New Exception("Debes ingresar una cantidad de meses mayor a cero")

        If (Me.tasa <= 0) Then Throw New Exception("La tasa de interes debe ser mayor a cero")


    End Sub


    ' aqui se calcula la cuotaMensual para el cliente con este metodo
    Public Function calcularCuota() As Double

        Dim resultado As Double = 0

        Try

            resultado = (_monto * (_tasa / 100 / 12)) / (1 - (1 + (_tasa / 100 / 12)) ^ -_meses)

        Catch ex As Exception
            Throw New Exception("Error al realizar el calculo en el metodo calculoCuota, de la clase calculos")
        End Try

        Return resultado

    End Function

    ' genero los calculos iniciales de la tabla amortizacion para llenar en la primera fila del datagridview llamado datagrid 1
    Public Sub GenerarCalculosIniciales()

        Try

            _interes = _monto * (_tasa / 100 / 12)
            _amortizacion = _cuota - InteresMensual
            _saldo = _monto - _amortizacion

        Catch ex As Exception
            Throw New Exception("Error 500 no se han podido calcular los datos")

        End Try

    End Sub

    ' con este metodo por cada iteracion del bucle para llenar el datagridview del frmAmortizacion, se llama a este metodo para seguir calculando la tabla de amortizacion
    Public Sub GenerarCalculosTablaAmortizacion()

        Try

            _interes = _saldo * (_tasa / 100 / 12)
            _amortizacion = _cuota - _interes
            _saldo = _saldo - _amortizacion

        Catch ex As Exception

            Throw New Exception("Error al generar los calculos de la tabla amortizacion, de la clase calculos ")

        End Try


    End Sub



End Class
