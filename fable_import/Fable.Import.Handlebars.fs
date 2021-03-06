namespace Fable.Import
open Fable.Core
open Fable.Import.JS

type [<AllowNullLiteral>] HandlebarsTemplateDelegate =
    [<Emit("$0($1...)")>] abstract Invoke: context: obj * ?options: obj -> string
