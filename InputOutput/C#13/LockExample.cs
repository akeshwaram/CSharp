using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput.C_13;

internal class LockExample
{
	public void Demo() { 
		Lock myLock = new();

		using (myLock.EnterScope()) {
			//do something


			//automatically releases the lock when the scope ends
		}
	}
}
