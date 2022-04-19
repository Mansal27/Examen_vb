Imports System


Module Program
    Sub Main(args As String())
        Dim t, IVA, d, st, monto, tasa, descuento As Double
        Console.WriteLine("Carlos Javier Estrada Jiménez")
        Console.WriteLine("Bienvenido operador al sistema de cálculo del restaurante la Ballena feliz")
        Console.WriteLine("Favor digite el monto de lo que consumió el cliente")
        monto = Console.ReadLine()
        d = DESmon(monto, tasa)
        descuento = d
        st = monto - descuento
        IVA = st * 0.18
        t = st + IVA
        Console.WriteLine("Estamos Procesando su operación")
        Console.WriteLine()
        Console.WriteLine("Descuento:" & d)
        Console.WriteLine("Subtotal:" & st)
        Console.WriteLine("Impuesto:" & IVA)
        Console.WriteLine("El monto total a pagar es:" & t)
        Console.ReadKey()
    End Sub


    Public Function DESmon(ByVal monto As Double, ByVal tasa As Double)
        Dim descuento As Double

        If monto > 49 And monto < 99 Then
            tasa = 0.05
            descuento = monto * tasa
            Return descuento
        ElseIf monto > 100 And monto < 149 Then
            tasa = 0.1
            descuento = monto * tasa
            Return descuento
        ElseIf monto > 150 Then
            tasa = 0.15
            descuento = monto * tasa
            Return descuento
        ElseIf monto > 0 And monto < 48 Then
            Console.WriteLine("No se le aplica tasa de descuento")
            Return descuento

        End If


    End Function
End Module