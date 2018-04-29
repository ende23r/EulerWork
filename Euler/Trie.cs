using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Trie
    {
        private class Node
        {
            public char key;
            public int val;
            public Node child;
            public Node next;

            public Node(char k) {
                this.key = k;
                this.child = null;
                this.next = null;
            }

            public Node Insert_Below(char key_below) {
                if (this.child == null) {
                    this.child = new Node(key_below);
                    return this.child;
                }

                else {
                    //Lexicographic sort doesn't matter here
                    Node child_iter = this.child;
                    while(true) {
                        if(child_iter.key == key_below) {
                            return child_iter;
                        }

                        else if(child_iter.next == null) {
                            child_iter.next = new Node(key_below);
                            return child_iter.next;
                        }

                        else {
                            child_iter = child_iter.next;
                        }
                    }
                }
            }


            public Node Insert_Right(char key_right) {
                return null;
            }

            //The trie will look best if presented as a preorder traversal (most legible)
            public override string ToString() {
                string left = (this.child != null) ? this.child.ToString() : "";
                string right = (this.next != null) ? this.next.ToString() : "";
                
                return String.Format("[ {0}, {1} ] {2}", this.key, left, right);
            }
        }

        private Node root;

        //Pass at least one string to initialize the Trie
        public Trie(string[] words) {
            root = new Trie.Node( words[0][0] );

            foreach (string word in words) {
                foreach (char c in word) {

                }
            }
        }

        public int find(string key) {
            return -1;
        }

        //Insert in the given value, unsorted.
        /*
        public void insert(string new_key, int new_val) {

        }
        //*/

        override public string ToString(){
            return root.ToString();
        }

        static void Main(string[] args) {
            string[] tests = { "HelloWorld" };
            Trie tester = new Trie(tests);

            Console.WriteLine(tester.ToString());

            Console.ReadLine();
        }
    }
}
