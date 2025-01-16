# Binary Search Tree Program

This project is a simple implementation of **Binary Search Trees (BST)** using C#. It provides a basic console-based program that allows users to construct and traverse a BST using either integers or strings as node values.

## Features

- **User Interaction**:  
  The program allows users to choose between integer or string data types for the tree nodes.
  
- **Custom Node Input**:  
  Users can specify how many nodes to insert and input the values interactively.

- **Tree Traversal**:  
  The program supports the three main types of tree traversals:
  1. **Preorder Traversal**: Root → Left Subtree → Right Subtree  
  2. **Inorder Traversal**: Left Subtree → Root → Right Subtree  
  3. **Postorder Traversal**: Left Subtree → Right Subtree → Root

## How It Works

A **Binary Search Tree (BST)** is a data structure where:
- Each node has at most two children (left and right).
- For every node:
  - Values in the left subtree are less than the node's value.
  - Values in the right subtree are greater than the node's value.

Mathematically, for any node \( N \) with value \( v \):
\[
\text{If } x \in \text{Left Subtree of } N, \text{ then } x < v.
\]
\[
\text{If } y \in \text{Right Subtree of } N, \text{ then } y > v.
\]

## Input Example

1. **Choose the data type**:  
   Enter `0` for integers or `1` for strings.

2. **Specify node count**:  
   Enter how many nodes you want to add to the tree.

3. **Provide node values**:  
   Input the values one by one as prompted.

## Output Example

The program outputs the traversal of the tree in three orders:
- **Preorder**: The root is visited before its subtrees.
- **Inorder**: Yields a sorted sequence of values for a BST.
- **Postorder**: The root is visited after its subtrees.

### Example Tree Visualization (Inorder Example)

If you input the values: 15, 10, 20, 8, 12, 17, 25,  
the tree would look like this:

```
        15
       /  \
     10    20
    /  \  /  \
   8   12 17  25
```

The **Inorder Traversal** would output:  
`8, 10, 12, 15, 17, 20, 25`

## Prerequisites

- .NET Framework
- Basic knowledge of console applications

## Usage

1. Clone the repository.  
2. Open the project in your preferred IDE (e.g., Visual Studio).  
3. Run the program and follow the on-screen instructions.
