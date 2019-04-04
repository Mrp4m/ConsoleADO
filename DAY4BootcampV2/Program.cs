using DAY4BootcampV2.Application;
using DAY4BootcampV2.Interfaces;
using DAY4BootcampV2.Models;
using DAY4BootcampV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, id = 0;
            TB_M_Suppliers supplier = new TB_M_Suppliers();
            TB_M_Items item = new TB_M_Items();
            TB_M_Sells sell = new TB_M_Sells();
            TB_T_TransactionItems transactionItem = new TB_T_TransactionItems();
            TB_T_TransactionItems_VM transactionItems_VM = new TB_T_TransactionItems_VM(); 

            ISupplier iSupplier;
            iSupplier = new SupplierController();

            IItem iItem;
            iItem = new ItemController();

            ISell iSell;
            iSell = new SellController();

            ITransactionItem iTransactionItem;
            iTransactionItem = new TransactionItemController();

            Menus menuu = new Menus();
            menu = menuu.ChooseTable();
            if (menu == 1)
            {

                //=======SUPPLIERS========\\
                switch (menuu.ChooseMenu())
                {
                    case 1:
                        iSupplier.Get();
                        break;
                    case 2:
                        iSupplier.Insert(supplier);
                        break;
                    case 3:
                        //Console.Write("Masukan ID : ");
                        //id = Convert.ToInt16(Console.ReadLine());
                        iSupplier.Update(supplier);
                        break;
                    case 4:
                        //Console.Write("Masukan ID : ");
                        //id = Convert.ToInt16(Console.ReadLine());
                        iSupplier.Delete();
                        break;
                    default:
                        Console.Write("Maaf");
                        break;
                }Console.Read();
                
                //===END OF SUPPLIER===\\

            }
            else if (menu == 2)
            {
                //===ITEM===\\
                //int ;
                switch (menuu.ChooseMenu())
                {
                    case 1:
                        iItem.Get();
                        Console.Read();
                        break;
                    case 2:
                        iItem.Insert(item);
                        Console.Read();
                        break;
                    case 3:
                        Console.Write("Masukan ID : ");
                        id = Convert.ToInt16(Console.ReadLine());
                        iItem.Update(item);
                        Console.Read();
                        break;
                    case 4:
                        Console.Write("Masukan ID : ");
                        id = Convert.ToInt16(Console.ReadLine());
                        iItem.Delete();
                        Console.Read();
                        break;
                    default :
                        Console.Write("Maaf");
                        break;
                }
                

                //===END OF ITEM===\\

            }
            else if (menu == 3)
            {
                switch (menuu.ChooseMenu())
                {
                    case 1:
                        iSell.Get();
                        Console.Read();
                        break;
                    case 2:
                        iItem.Insert(item);
                        Console.Read();
                        break;
                    case 3:
                        Console.Write("Masukan ID : ");
                        id = Convert.ToInt16(Console.ReadLine());
                        iItem.Update(item);
                        Console.Read();
                        break;
                    case 4:
                        Console.Write("Masukan ID : ");
                        id = Convert.ToInt16(Console.ReadLine());
                        iItem.Delete();
                        Console.Read();
                        break;
                    default:
                        Console.Write("Maaf");
                        break;
                }
            }
            else if (menu == 4)
            {
                switch (menuu.ChooseMenu())
                {
                    case 1:
                        iSell.Get();
                        Console.Read();
                        break;
                    case 2:
                        iTransactionItem.Insert(transactionItem);
                        Console.Read();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.Write("Maaf");
                        break;
                }
            }
            //------------------------------------------------------
            
            Console.Read();

        }
    }
    public class Menus
    {
        public int ChooseTable()
        {
            int menu;
            Console.WriteLine("Menu :");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("2. Item");
            Console.WriteLine("3. Sell");
            Console.WriteLine("4. Transaction Item");
            Console.WriteLine("-----------------------");
            Console.Write("Pilih Menu : ");
            menu = Convert.ToInt16(Console.ReadLine());
            return menu;
        }
        public int ChooseMenu()
        {
            int menu;
            Console.WriteLine("Menu :");
            Console.WriteLine("1. View Data");
            Console.WriteLine("2. Insert Data");
            Console.WriteLine("3. Update Data");
            Console.WriteLine("4. Delete Data");
            Console.WriteLine("-----------------------");
            Console.Write("Pilih Menu : ");
            menu = Convert.ToInt16(Console.ReadLine());
            return menu;
        }
    }
}
