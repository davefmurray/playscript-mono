// Copyright 2013 Zynga Inc.
//	
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//		
//      Unless required by applicable law or agreed to in writing, software
//      distributed under the License is distributed on an "AS IS" BASIS,
//      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//      See the License for the specific language governing permissions and
//      limitations under the License.

using System;
using System.Collections.Generic;
using System.Collections;

namespace _root
{
	public class Array : List<dynamic>
	{

		//
		// Constants
		//

		public const uint CASEINSENSITIVE = 1;

		public const uint DESCENDING = 2;

		public const uint NUMERIC = 16;

		public const uint RETURNINDEXEDARRAY = 8;

		public const uint UNIQUESORT = 4;

		public Array() {
		}

		public Array(object arg1, params object[] args) {
			if (arg1 is int || arg1 is double) {
				int n = (int)arg1;
				for (var i = 0; i < n; i++) {
					this.Add (null);
				}
			} else {
				this.Add (arg1);
				if (args.Length > 0) {
					this.AddRange(args);
				}
			}
		}

		public Array (IEnumerable list)
		{
			foreach (var i in list) {
				this.Add (i);
			}
		}


		public int length 
		{
			get { return Count; }
			set { 
				throw new NotImplementedException();
			}
		}

		// Concatenates the elements specified in the parameters with the elements in an array and creates a new array.
		public Array concat(params object[] args) {
			var a = new Array();
			a.AddRange(this);
			a.AddRange (args);
			return null;
		}
	
		// Executes a test function on each item in the array until an item is reached that returns false for the specified function.
		public bool every(Delegate callback, object thisObject = null) {
			throw new NotImplementedException();
		}

		// Executes a test function on each item in the array and constructs a new array for all items that return true for the specified function.
		public Array filter(Delegate callback, object thisObject) {
			throw new NotImplementedException();
		}
 	 	
		// Executes a function on each item in the array.
		public void forEach(Delegate callback, object thisObject = null) {
			throw new NotImplementedException();
		}
 	 	
		// Searches for an item in an array by using strict equality (===) and returns the index position of the item.
		public int indexOf(object searchElement, int fromIndex = 0) {
			return this.IndexOf(searchElement, fromIndex);
		}

		// Converts the elements in an array to strings, inserts the specified separator between the elements, concatenates them, and returns the resulting string.
		public string join() 
		{
			return System.String.Join (",", (IEnumerable<object>)this);
		}

		// Converts the elements in an array to strings, inserts the specified separator between the elements, concatenates them, and returns the resulting string.
		public string join(object sep) 
		{
			return System.String.Join((System.String)sep, (IEnumerable<object>)this);
		}
 	 	
		// Searches for an item in an array, working backward from the last item, and returns the index position of the matching item using strict equality (===).
		public int lastIndexOf (object searchElement, int fromIndex = 0x7fffffff)
		{
			if (fromIndex == 0x7fffffff) {
				return this.LastIndexOf (searchElement);
			} else {
				return this.LastIndexOf (searchElement, fromIndex);
			}
		}
 	 	
		// Executes a function on each item in an array, and constructs a new array of items corresponding to the results of the function on each item in the original array.
		public Array map(Delegate callback, object thisObject = null) {
			throw new NotImplementedException();
		}
 	 	
		// Removes the last element from an array and returns the value of that element.
		public dynamic pop() {
			dynamic v = this[Count - 1];
			this.RemoveAt (Count - 1);
			return v;
		}
 	 	
		// Adds one elements to the end of an array and returns the new length of the array.
		public uint push(object val) {
			this.Add (val);
			return (uint)Count;
		}

		// Adds one or more elements to the end of an array and returns the new length of the array.
		public uint push(object arg1, params object[] args) {
			this.Add (arg1);
			this.AddRange(args);
			return (uint)Count;
		}
 	 	
		// Reverses the array in place.
		public Array reverse() {
			throw new NotImplementedException();
		}
 	 	
		// Removes the first element from an array and returns that element.
		public dynamic shift() {
			dynamic first = this[0];
			this.RemoveAt (0);
			return first;
		}
 	 	
		// Returns a new array that consists of a range of elements from the original array, without modifying the original array.
		public Array slice(int startIndex = 0, int endIndex = 16777215) {
			throw new NotImplementedException();
		}
 	 	
		// Executes a test function on each item in the array until an item is reached that returns true.
		public bool some(Delegate callback, object thisObject = null) {
			throw new NotImplementedException();
		}
 	 	
		// Sorts the elements in an array.
		public Array sort(params object[] args) {
			throw new NotImplementedException();
		}
 	 	
		// Sorts the elements in an array according to one or more fields in the array.
		public Array sortOn(object fieldName, object options = null) {
			throw new NotImplementedException();
		}
 	 	
		// Adds elements to and removes elements from an array.
		public void splice(int startIndex, int deleteCount = 0) {
			if (deleteCount == 1) {
				this.RemoveAt(startIndex);
			} else {
				this.RemoveRange(startIndex, deleteCount);
			}
		}

		public void splice(int startIndex, int deleteCount, params object[] values) {
			if (deleteCount == 1) {
				this.Remove (startIndex);
			} else {
				this.RemoveRange (startIndex, deleteCount);
			}
			this.InsertRange(startIndex, values);
		}

		public uint unshift(object o) {
			throw new NotImplementedException();
		}

		public uint unshift(object arg1, params object[] args) {
			throw new NotImplementedException();
		}

}
}

