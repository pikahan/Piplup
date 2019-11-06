module Absyn 

type expr = 
  | CstI of int
  | CstB of bool
  | Var of string
  | Let of string * expr * expr
  | Prim of string * expr * expr
  | If of expr * expr * expr
  | Letfun of string * string * expr * expr    (* (f, x, fBody, letBody) *)
  | Call of expr * expr

// and POper =
//     | PlusOp
//     | MinusOp
//     | TimesOp
//     | DivideOp
//     | EqOp
//     | NeqOp
//     | GtOp
//     | GeOp
//     | LtOp
//     | LeOp