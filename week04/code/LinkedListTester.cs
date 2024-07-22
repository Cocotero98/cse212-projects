public static class LinkedListTester
{
    public static void Run()
    {

        var testList = new LinkedList<int>();
        testList.AddFirst(1);
        testList.AddLast(5);
        testList.AddLast(6);
        var firstl = testList.First();
        var lastl = testList.Last();
        Console.WriteLine(firstl);
        Console.WriteLine(lastl);


        // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        var ll = new LinkedList();
        ll.InsertTail(1);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(2);
        ll.InsertHead(3);
        ll.InsertHead(4);
        ll.InsertHead(5);

        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1};
        ll.InsertTail(0);
        ll.InsertTail(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1};
        ll.InsertTail(5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0, -1, 5};
        ll.RemoveTail();

        var ll2 = new LinkedList();
        ll2.InsertTail(1);
        Console.WriteLine(ll2.HeadAndTailAreNotNull()); // True

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        ll.RemoveTail();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1, 0}
        ll.RemoveTail();
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 3, 2, 2, 2, 1}

        var ll3 = new LinkedList();
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        ll3.InsertHead(2);
        ll3.RemoveTail();
        Console.WriteLine(ll3.ToString()); // <LinkedList>{}
        Console.WriteLine(ll3.HeadAndTailAreNull()); // True

        var llFour = new LinkedList();
        llFour.InsertTail(1);
        llFour.InsertHead(2);
        llFour.InsertHead(4);
        llFour.RemoveTail();
        Console.WriteLine(llFour.ToString()); // <LinkedList>{4, 2}


        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        ll.InsertAfter(3, 35);
        ll.InsertAfter(5, 6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(-1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 3, 35, 2, 2, 2, 1}
        ll.Remove(3);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 6, 4, 35, 2, 2, 2, 1}
        ll.Remove(6);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2, 1}
        ll.Remove(1);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(7);
        Console.WriteLine(ll.ToString()); // <LinkedList>{5, 4, 35, 2, 2, 2}
        ll.Remove(5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2, 2}
        ll.Remove(2);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 2, 2}

        var ll4 = new LinkedList();
        ll4.Remove(0);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{}
        ll4.InsertHead(2);
        ll4.Remove(2);
        Console.WriteLine(ll4.ToString()); // <LinkedList>{}
        Console.WriteLine(ll4.HeadAndTailAreNull()); // True

        var llTwo = new LinkedList();
        llTwo.InsertTail(1);
        llTwo.InsertHead(3);
        llTwo.InsertHead(4);
        llTwo.InsertHead(5);
        llTwo.Remove(3);
        Console.WriteLine(llTwo.ToString()); //<LinkedList>{5, 4, 1}

        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        ll.Replace(2, 10);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(7, 5);
        Console.WriteLine(ll.ToString()); // <LinkedList>{4, 35, 10, 10}
        ll.Replace(4, 100);
        Console.WriteLine(ll.ToString()); // <LinkedList>{100, 35, 10, 10}
        ll.Replace(35, 45);
        Console.WriteLine(ll.ToString()); // <LinkedList>{100, 45, 10, 10}


        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        Console.WriteLine(ll.Reverse().AsString()); // <IEnumerable>[10, 10, 45, 100}
    }
}