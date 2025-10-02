namespace Arvores
{
    //<T> -> O T é a especificação de um tipo genérico (Generics)
    public class TreeNode<T>
    {
        //O atributo Data do tipo generic T armazenará o valor de fato
        public T Data { get; set; }
        //O atributo Parent será a referência ao Nó Pai da árvore
        public TreeNode<T> Parent { get; set; }
        //O atributo Children é uma lista dos Nós Filhos, tabém do tipo T Generic
        public List<TreeNode<T>> Children { get; set; }
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}