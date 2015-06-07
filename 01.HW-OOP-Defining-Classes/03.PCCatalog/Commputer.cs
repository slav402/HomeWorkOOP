
using System;
using System.Collections.Generic;

class Commputer
{
    private string name;
    private List<Components> components;

    public string Name {//comment
        get
        {
            return this.name; 
            
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            this.name = value;
        }
    }
    public List<Components> Components {
        get
        {
            return this.components; 
            
        }
        set
        {
            if (components.Count == 0)
            {
                throw new ArgumentNullException("Computer muste have a components");
            }
            this.components = value;
        }
    }

    

    public Commputer()
    {
        this.Name = name;
        this.Components = components;
    }





}

