using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace CPSProject.Models.db
{
    public static class EnumerableExtension
    {
        private static TransactionScope CreateNoLockTransaction()
        {
            var options = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };
            return new TransactionScope(TransactionScopeOption.Required, options);
        }


        public static List<T> ToListNoLock<T>(this IEnumerable<T> query)
        {
            using (TransactionScope ts = CreateNoLockTransaction())
            {
                return query.ToList();
            }
        }
    }

}
