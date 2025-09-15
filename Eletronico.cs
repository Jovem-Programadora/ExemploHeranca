namespace ExemploHeranca;

public class Eletronico : Produto
{
    private int tensao;
    private int garantia;

    public Eletronico(int codigo, string nome, string descricao, decimal preco, int tensao, int garantia)
    {
        this.codigo = codigo;
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.tensao = tensao;
        this.garantia = garantia;
    }

    public override string ToString()
    {
        return $"{this.nome} / {this.descricao} / {this.preco}";
    }
}
