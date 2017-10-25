Namespace My

    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean



            Me.MinimumSplashScreenDisplayTime = 3000 'Milliseconds

            Return MyBase.OnInitialize(commandLineArgs)



        End Function
    End Class
End Namespace

