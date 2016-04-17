//Code017 Vincent Tang
//WindLang Project
//LA Part Autometa
using System;
using System.Collections.Generic;

namespace WindLang
{
    namespace Lexer
    {
        public class AutometaMachine
        {
            private AutometaState Begin;
    
            public AutometaMachine(AutometaState Begin)
            {
                this.Begin = Begin;
            }
    
            public Token Query(string Word)
            {
                string tWord = Word;
                AutometaState CurrentState = Begin;
                try{
                    do{
                        CurrentState = CurrentState[tWord[0]];
                        tWord = tWord.Substring(1);
                    }while(Word.Length > 0)
                }catch{
                    return new Token(TokenType.Unknown,Word,ExtraInformation = "Could not match anything");
                }
                if(CurrentState.IsEndState){
                    return new Token(CurrentState.Type,Word);
                }else{
                    return new Token(TokenType.Unknown,Word,ExtraInformation = "Could not match anything");
                }
            }
        }
        
        
        
        public class AutometaState
        {
            bool IsEndState{public get,private set;}
            TokenType Type{public get,private set;}
            private Dictionary<char,AutometaState> Mapper;
            
            public AutometaState(Dictionary<char,AutometaState> Mapper,bool IsEndState = false,TokenType Type = TokenType.NotAType)
            {
                this.Mapper = mapper;
                this.IsEndState = IsEndState;
                this.Type = Type;
            }
            
            public AutometaState this[char indexer]
            {
                get{
                    return mapper[indexer];
                }
            }
        }
        
        
        
        public class StdEnvironment
        {
            public static AutometaState GetHead()
            {
            
            }
        }
    }
}
