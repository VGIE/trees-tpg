namespace Lists;

//TODO #1: Copy your List<T> class (List.cs) to this project and overwrite this file.
using Lists;
using System;
using System.Collections;
using System.Xml;
using Trees;

public class ListNode<T>
{
    public T Value;
    public ListNode<T> Next = null;
    public ListNode<T> Previous = null;

    

    public ListNode(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

public class List<T> : IList<T>
{
    ListNode<T> First = null;
    ListNode<T> Last = null;
    int m_numItems = 0;

    public override string ToString()
    {
        ListNode<T> node = First;
        string output = "[";

        while (node != null)
        {
            output += node.ToString() + ",";
            node = node.Next;
        }
        output = output.TrimEnd(',') + "] " + Count() + " elements";

        return output;
    }

    public int Count()
    {
        //TODO #1: return the number of elements on the list
        return m_numItems;
    }

    public T Get(int index)
    {
        //TODO #2: return the element on the index-th position. O if the position is out of bounds
        
         ListNode<T> lista = First;
                if (index < 0) return default;

                int i = 0;
                while (lista != null)
                {
                    if (i == index) return lista.Value;
                    lista = lista.Next;
                    i++;
                }
                return default;
        
    }

    public void Add(T value)
    {
        //TODO #3: add a new integer to the end of the list

            ListNode<T> lista = First;

            ListNode<T> nueva = new ListNode<T> (value);
        if (First == null)
        {
            First = nueva;
            Last = nueva;
            m_numItems++;

            return;
        }
        else
        {
            Last.Next = nueva;
            nueva.Previous = Last;
            Last = nueva;
            m_numItems++;

        }

            


    }

    public T Remove(int index)
    {
        //TODO #4: remove the element on the index-th position. Do nothing if position is out of bounds

        ListNode<T> lista = First;
        int i = 0;

        if (lista == null) return default;
        if(index< 0 || index >= m_numItems) return default;
        if (index == 0)
        {
            T value = First.Value;
            First = First.Next;

            if (First != null) First.Previous = null; ///////////

            m_numItems--;
            return value;
        }

        if (index == m_numItems - 1)
        {
            T remove = Last.Value;
            Last = Last.Previous;
            Last.Next = null;
            m_numItems--;
            return remove;
        }

        while (lista != null && i<index)
        {
            lista = lista.Next;
            i++;
        }

        if (lista == null) return default; 

   
    lista.Previous.Next = lista.Next;
    lista.Next.Previous = lista.Previous;

    m_numItems--;
    return lista.Value;

        
    }

    public void Clear()
    {
        //TODO #5: remove all the elements on the list
        First = null;
        m_numItems = 0;
    }

    public IEnumerator GetEnumerator()
    {
        //TODO #6 : Return an enumerator using "yield return" for each of the values in this list
        
        ListNode<T> lista = First;
            
            while (lista.Next != null)
            {
                lista = lista.Next;

                yield return lista.Value;
                
            }
        
    }
}