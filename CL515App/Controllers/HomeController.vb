Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Instructions() As ActionResult
        ViewData("Message") = "Detailed Instructions For Using This App"

        Return View()
    End Function

    Function Help() As ActionResult
        ViewData("Message") = "Get Help From CNS"

        Return View()
    End Function

    Function ManageTags() As ActionResult
        ViewData("Message") = "Manage Tags, Tag Values, and Assign Tags to Parts"

        Return View()
    End Function
End Class
