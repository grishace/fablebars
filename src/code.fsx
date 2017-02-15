#r "../node_modules/fable-core/Fable.Core.dll"
#load "../fable_import/Fable.Import.Handlebars.fs"

open Fable.Core 
open Fable.Import
 
Node.require.Invoke("core-js") |> ignore
let hb = Node.require.Invoke("../../templates/hello.handlebars") :?> HandlebarsTemplateDelegate

type Hello = { who:string }
let element = Browser.document.getElementById "hello"
element.innerHTML <- hb.Invoke <| {who = "Fable"}