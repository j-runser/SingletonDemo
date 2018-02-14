using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Hand // This is the Singleton class
    {

        //"Use the static modifier to declare a static member, which belongs
        //to the type itself rather than to a specific object." - microsoft docs
        private static Hand handInstance;
        private HoldableItem heldItem;

        // This is the instantiation, it is private to fit the model for the
        // singleton design pattern.
        private Hand(HoldableItem heldItem)
        {
            // Same as in Java differnt in C++
            this.heldItem = heldItem;
        }

        // This is the getInstance method of the singleton.
        public static Hand PickUpObject(HoldableItem heldItem)
        {
            if(handInstance == null)
            {
                handInstance = new Hand(heldItem);
            }
            return handInstance;
        }

        // this is the doSometing() method
        // The object does not get completely deleted, look into garbage collection.
        public static Hand DropObject()
        {
            if(handInstance != null)
            {
                handInstance = null;
            }
            return handInstance;
        }

        // another doSomething() menthod
        public string GetHeldObjectName()
        {
            if(handInstance != null)
            {
                return heldItem.ItemName;
            }
            return "Not holding anything.";
        }

    }
}
