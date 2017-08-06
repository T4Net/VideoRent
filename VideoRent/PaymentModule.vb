'The primary difference between a Class & a Structure Is that a Class Is a
'Reference type, it creates an Object (a value) that exists On the Heap.
'While a Structure Is a Value type, it creates a value that exists On the
'stack memory so in general work faster than reference types that live On the heap.
Imports VideoRent

Module PaymentModule
    Dim dBase As New Database
    Public Structure Payment
        Private pCustomerID As Integer
        Private pFullName As String
        Private pCopyID As Integer
        Private pTitle As String
        Private pRentID As Integer
        Private pRate As Decimal
        Private pTotal As Double
        Private pDuration As Integer
        Private pFine As Integer

        Public Sub New(cID As Integer, fName As String, cusID As Integer,
                       mTitle As String, rID As Integer, rPrice As Double,
                       Optional leaseTime As Integer = 0)
            CustomerID = cusID
            FullName = fName
            CopyID = cID
            Title = mTitle
            RentID = rID
            Rate = rPrice
            Duration = leaseTime
        End Sub

        Friend Property CustomerID() As Integer
            Get
                Return pCustomerID
            End Get
            Set(value As Integer)
                pCustomerID = value
            End Set
        End Property

        Friend Property FullName() As String
            Get
                Return pFullName
            End Get
            Set(value As String)
                pFullName = value
            End Set
        End Property

        Friend Property CopyID() As Integer
            Get
                Return pCopyID
            End Get
            Set(value As Integer)
                pCopyID = value
            End Set
        End Property

        Friend Property Title() As String
            Get
                Return pTitle
            End Get
            Set(value As String)
                pTitle = value
            End Set
        End Property

        Friend Property RentID() As Integer
            Get
                Return pRentID
            End Get
            Set(value As Integer)
                pRentID = value
            End Set
        End Property

        Friend Property Rate() As Decimal
            Get
                Return pRate
            End Get
            Set(value As Decimal)
                pRate = value
            End Set
        End Property

        Friend Property Total() As Double
            Get
                Return pTotal
            End Get
            Set(value As Double)
                pTotal = value
            End Set
        End Property

        Friend Property Duration() As Integer
            Get
                Return pDuration
            End Get
            Set(value As Integer)
                pDuration = value
            End Set
        End Property

        Friend Property Fine() As Integer
            Get
                Return pFine
            End Get
            Set(value As Integer)
                pFine = value
            End Set
        End Property

        Friend Sub CalculateDuration(rentalTime As Date, hireDate As Date)
            If rentalTime.Date <> hireDate.Date Then
                'Dim ts As TimeSpan = dateOfReturn.Subtract(hireDate)
                'Duration = Math.Round(ts.TotalDays)
                Duration = rentalTime.Subtract(hireDate).Days
            Else
                Duration = 0
            End If
        End Sub

        Friend Sub CalculateTotal(ByVal fine As Double)
            Total = Total + fine
        End Sub

        Friend Sub CalculateTotal(ByVal rate As Double, ByVal days As Integer)
            Total = rate * days
        End Sub

        Friend Sub CalculateTotal(ByVal rate As Double, ByVal days As Integer, ByVal fine As Integer)
            Total = (rate * days) + fine
        End Sub

        Friend Sub SetPaymentDetails()
            With VideoRent.MainForm
                .CustomerIDTextBox_Payment.Text = CustomerID.ToString()
                .FullNameTextBox_Payment.Text = FullName.ToString()
                .CopyIDTextBox_Payment.Text = CopyID.ToString()
                .TitleTextBox_Payment.Text = Title
                .RentIDTextBox_Payment.Text = RentID.ToString()
                .RateTextBox_Payment.Text = Rate.ToString()
                .TransactionOwnerTextBox_Payment.Text = .userLog
                .NoOfDaysTextBox_Payment.Text = Duration.ToString()
                .TotalTextBox_Payment.Text = Total.ToString()
                .FineTextBox_Payment.Text = Fine.ToString()
            End With
        End Sub

    End Structure

    Public Function MakeTransaction(payID As Integer, total As Decimal,
                                    Optional renID As Integer = Nothing) As Boolean
        Dim operation As Boolean = True
        Dim customerPay As VideoRent.payment
        Dim condition As Func(Of VideoRent.payment, Boolean)
        'Where extension method accepts a generic delegate Func(Of T, Boolean) 
        If Not renID = Nothing Then
            condition = (Function(p) p.rentID = renID)
        Else
            condition = (Function(p) p.paymentID = payID)
        End If
        Try
            'customerPay = dBase.payments.Where(condition).FirstOrDefault()
            Dim database As New Database(RepoType.Payment)
            customerPay = database.GetPayment(condition)
            If customerPay.amount >= 0 And
                customerPay.paymentDate IsNot Nothing Then
                operation = False
            Else
                customerPay.amount = Math.Abs(total)
                customerPay.paymentDate = Now()
                'dBase.SaveChanges()
                database.SavePayments()
            End If
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
            operation = False
        Finally
            customerPay = Nothing
        End Try
        Return operation
    End Function
End Module
