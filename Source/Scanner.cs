using System;
namespace WindLang
{
    namespace Lexer
    {
        public class PublicExchanger
        {
            public static Token Exchange(RawToken raw)
            {
                if(raw.Lexeme == "("){
                    return new Token(TokenType.LParen);
                }else if(raw.Lexeme == ")"){
                    return new Token(TokenType.RParen);
                }else if(raw.Lexeme == "["){
                    return new Token(TokenType.LBracket);
                }else if(raw.Lexeme == "]"){
                    return new Token(TokenType.RBracket);
                }else if(raw.Lexeme == "{"){
                    return new Token(TokenType.LBrace);
                }else if(raw.Lexeme == "}"){
                    return new Token(TokenType.RBrace);
                }
                //UNFINISHED!
            }
        }
        
        public class Scanner
        {
            
        }
    }
}
