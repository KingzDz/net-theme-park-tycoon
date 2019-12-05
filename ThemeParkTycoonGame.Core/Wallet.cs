using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Wallet
    {
        public const string DEFAULT_PAYMENT_REASON = "Paid to an unknown entity";

        public delegate void BalanceChangedEvent(object sender, BalanceChangedEventArgs e);
        public event BalanceChangedEvent BalanceChanged;

        private decimal balance;
        public decimal Balance {
            get
            {
                return balance;
            }
            private set
            {
                DoBalanceChange(value);
            }
        }

        public List<TransactionLog> History { get; private set; }

        private void DoBalanceChange(decimal balance)
        {
            // Check if someone is handling this event
            if (BalanceChanged != null)
            {
                BalanceChanged.Invoke(this, new BalanceChangedEventArgs()
                {
                    OldBalance = this.Balance,
                    Balance = balance
                });
            }

            this.balance = balance;
        }

        public Wallet(decimal balance = 0)
        {
            this.History = new List<TransactionLog>();

            SubtractFromBalance(-balance, "Got salary to spend at a theme park");
        }

        public void SubtractFromBalance(decimal amount, string reason = null)
        {
            if (reason == null)
                reason = DEFAULT_PAYMENT_REASON;

            this.Balance -= amount;

            this.History.Add(new TransactionLog()
            {
                Amount = amount,
                Reason = reason
            });
        }
    }

    public class TransactionLog
    {
        public TransactionLog()
        {
            this.Time = DateTime.Now;
        }

        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public DateTime Time { get; set; }
    }

    public class BalanceChangedEventArgs : EventArgs
    {
        public decimal OldBalance;
        public decimal Balance;
    }
}
