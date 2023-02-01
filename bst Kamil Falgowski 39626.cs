class BST
{
	Node Root = null;
	public void Add(int key)
	{
		if (root == null)
		{
			root = new Node(key);
			return;
		}
		Node current = root;
		while (true)
		{
			if (key < current.Key)
			{
				if (current.Left == null)
				{
					current.Left = new Node(key, current);
					break;
				}
				current = current.Left;
			}
			else
			{
				if (current.Right == null)
				{
					current.Right = new Node(key, current);
					break;
				}
				current = current.Right;
			}
		}
	}
	public bool Contains(int key)
	{
		Node node = Root;
		while (node != null)
			if (key == node.Key)
				return true;
			else if (key < node.Key)
				node = node.Left;
			else
				node = node.Right;
		return false;
	}
	class Node
	{
		public Node
			Parent = null,
			Left = null,
			Right = null;
		public int
			Key;
		public Node(
			int key,
			Node parent = null
		)
		{
			Key = key;
			Parent = parent;
		}
	}

	
}