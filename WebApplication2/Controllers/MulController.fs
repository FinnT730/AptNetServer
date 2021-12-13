namespace WebApplication2.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open WebApplication2

[<ApiController>]
[<Route("[controller]")>]
type MulController (logger : ILogger<MulController>) =
    inherit ControllerBase()
//    
//    [<HttpPost("num")>]
//    member _.finn() =
//        0


    [<HttpOptions>]
    [<HttpGet>]
    member _.Get([<HttpPost>]num: int) =
        { _val = (num * num) }
//        [|
//            for index in 0..100 ->
//                { isEven = (index % 2 = 0)
//                  index = index }
//        |]