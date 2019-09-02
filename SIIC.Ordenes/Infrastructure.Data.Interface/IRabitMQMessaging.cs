using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Interface
{
	public interface IRabitMQMessaging
	{
		void SendMessageRabitMQ();
	}
}
