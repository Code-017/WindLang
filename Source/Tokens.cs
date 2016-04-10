using System;
namespace WindLang
{
    namespace Lexer
    {
        public class RawToken
        {
            public RawToken(string aLexeme)
            {
                Lexeme = aLexeme;
            }
            string Lexeme {public get;private set;}
        }
        
        public enum TokenType
        {
            LParen,RParen,LBracket,RBracket,LBrace,RBrace,Id,IntegerLiteral,StringLiteral,FloatLiteral,Use,Fn,Assign,LE,GE,Less,Greater,Equal,NotEq,True,False,Return,And,Or,Xor,Not,Break,
            Continue,In,If,Else,While,For,Try,Except,Finally,Assert,Add,Minus,Multiply,Divide,AddInPlace,MinusInPlace,MultiplyInPlace,DivideInPlace,
        }
        
        public class Token
        {
            public Token(TokenType aType)
            {
                Type = aType;
            }
            TokenType Type{public get;private set;}
        }
        
        public class IdToken:Token
        {
            public IdToken(string aIdentifier):base(TokenType.Id)
            {
                Identifier = aIdentifier;
            }
            string Identifier{public get;private set;}
        }
        
        public class IntegerLiteralToken:Token
        {
            public IdToken(int aLiteral):base(TokenType.IntegerLiteral)
            {
                Literal = aLiteral;
            }
            int Literal{public get;private set;}
        }
        
        public class FloatLiteralToken:Token
        {
            public IdToken(double aLiteral):base(TokenType.IntegerLiteral)
            {
                Literal = aLiteral;
            }
            double Literal{public get;private set;}
        }
    }
}
