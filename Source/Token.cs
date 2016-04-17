//Code017 Vincent Tang
//WindLang Project
//LA Part Token
using System;

namespace WindLang
{
    namespace Lexer
    {
        public class Token
        {
            TokenType Type{public get;private set;}
            string Value{public get;private set;}
            string ExtraInformation{public get;private set;}
            
            public Token(TokenType Type,string Value,string ExtraInformation = "No more information")
            {
                this.Type = Type;
                this.Value = Value;
                this.ExtraInformation = ExtraInformation;
            }
            
            public override string ToString()
            {
                return "(" + Type + ")[Value = " + Value + ", ExtraInformation = " + ExtraInformation + "]"
            }
        }
        
        
        
        public enum TokenType
        {
            NotAType,Unknown,
            OpAdd,OpMinus,OpMultiply,OpDivide,OpInPlaceAdd,OpInPlaceMInux,OpInPlaceMultiply,OpInPlaceDivide,OpLT,OpGT,OpLE,OpGE,OpEq,OpNE,OpAssign,
            True,False,
            StringLiteral,IntegerLiteral,FloatLiteral,
            tString,tInteger,tFloat,
            LParen,RParen,LBracket,RBracket,LBrace,RBrace,
            For,While,Do,If,Else,Match,Try,Catch,Raise,Use,Fn,
        }
    }
}
