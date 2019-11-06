module Absyn 

type PExpr = 
  | CstI of int
  | CstB of bool
  | Var of string
  | Let of string * PExpr * PExpr
  | Prim of string * PExpr * PExpr
  | If of PExpr * PExpr * PExpr
  | Letfun of string * string * PExpr * PExpr    (* (f, x, fBody, letBody) *)
  | Call of PExpr * PExpr

and POper =
    | PlusOp
    | MinusOp
    | TimesOp
    | DivideOp
    | EqOp
    | NeqOp
    | GtOp
    | GeOp
    | LtOp
    | LeOp