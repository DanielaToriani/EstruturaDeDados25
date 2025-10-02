using Arvores;

// Declaração de variável tree do tipo Tree onde Tree<int> agora é de inteiros
Tree<int> tree = new Tree<int>();

// Root é o Nó raiz da árvore instanciado com seu tipo TreeNode onde TreeNode, por sua vez, é de inteiros
tree.Root = new TreeNode<int>();
tree.Root.Data = 100;

tree.Root.Children =
    new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent =tree.Root },
    new TreeNode<int>() { Data = 1, Parent =tree.Root },
    new TreeNode<int>() { Data = 150, Parent =tree.Root }
};

tree.Root.Children[2].Children =
new List<TreeNode<int>>
{
    new TreeNode<int>(){
        Data = 30,
        Parent = tree.Root.Children[2]
    }
};
        