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
type IsOddController (logger : ILogger<IsOddController>) =
    inherit ControllerBase()
//    
//    [<HttpPost("num")>]
//    member _.finn() =
//        0


    [<HttpOptions>]
    [<HttpGet>]
    member _.Get([<HttpPost>]num: double) =
        { isOdd = (num % 2.0 = 1.0)
          index = num }
//        [|
//            for index in 0..100 ->
//                { isEven = (index % 2 = 0)
//                  index = index }
//        |]