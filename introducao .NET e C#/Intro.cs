// "namespace" serve para separar as classes
namespace CSharp
{
    // nao pode repetir o nome das classes
    // uma "classe" vira um "objeto" quando é instanciada
    class CSharp
    {
        // uma "classe" contem "membros"
        // "membros sao campos, propriedades, métodos e eventos
        public string Campo_Nome{get;set}
        public string Local_Estado{get;set}
        public int Dados_Idade{get;set}
    }
}

namespace CSharp2
{
    // só pode usar o mesmo nome se criar um outro "namespace"
    class Classe
    {
        
    }
    
}

