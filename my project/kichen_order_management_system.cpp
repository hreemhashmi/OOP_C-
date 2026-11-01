#include <iostream>
#include <conio.h>
using namespace std;

int main()
{
    int totalsize = 100;

    string dishes[totalsize];
    int prices[totalsize];
    int count = 0;
    int revenue = 0;

    string orderdishes[totalsize];
    int orderquantity[totalsize];
    float ordertotal[totalsize];
    int orders;

    while (true)
    {
        // Main header
        system("cls");
        cout << " ----------------------------------------------- " << endl;
        cout << " ------Home Kichen Order Management System------ " << endl;
        cout << " ----------------------------------------------- " << endl;

        cout << "                    Main Mnue  " << endl;
        cout << " 1 . Amin " << endl;
        cout << " 2 . Customer " << endl;
        cout << " 3 . Staff " << endl;
        cout << " 4 . Exit " << endl;
        cout << " choose Option: ";
        int option;
        cin >> option;
        cout << " You Choose " << option << endl;

        if (option == 1)
        {
            // Write here admin code
            for (int i = 0; i < 3; i++)
            {
                system("cls");
                cout << " Login Attemps  " << i + 1 << endl;
                cout << " Enter User Name: ";
                string username;
                cin >> username;
                cout << " Enter Password: ";
                string password;
                cin >> password;

                if (username == "admin" && password == "789")
                {
                    cout << " Login Success " << endl;
                    cout << " press anykey to countinue.......";
                    getch();
                    // loop for admin manue
                    while (true)
                    {
                        system("cls");
                        cout << "  ========== Admin Mnue ========== " << endl;
                        cout << "1.  Add Dishes " << endl;
                        cout << "2.  View All Dishes " << endl;
                        cout << "3.  Search Dish " << endl;
                        cout << "4.  Update Dish " << endl;
                        cout << "5.  Delete Dish " << endl;
                        cout << "6.  Add Dish Price " << endl;
                        cout << "7.  Sort Dishes (Low to High) " << endl;
                        cout << "8.  Sort Dishes (High to Low) " << endl;
                        cout << "9.  View Total Revenue " << endl;
                        cout << "10. View Oreder History " << endl;
                        cout << "11. Staff Management " << endl;
                        cout << "12. Exit " << endl;

                        cout << " Choose Option : ";
                        int adminoption;
                        cin >> adminoption;
                        // 1. add dish
                        if (adminoption == 1)
                        {
                            cout << " Enter Dish Name : ";
                            cin >> dishes[count];
                            cout << " Enter Prices : ";
                            cin >> prices[count];
                            count++;
                            cout << " press anykey to countinue.....";
                            getch();
                        } // view dishes
                        else if (adminoption == 2)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                if (dishes[i] != " ")
                                {
                                    cout << i + 1 << ". " << dishes[i] << " \t " << endl;
                                }
                            }

                            cout << " press anykey to countinue....... ";
                            getch();
                        } // search dishes
                        else if (adminoption == 3)
                        {
                            string searchdish;
                            cout << " Enter Search Dish Name :";
                            cin >> searchdish;
                            bool found = false;
                            for (int i = 0; i < count; i++)
                            {
                                if (dishes[i] == searchdish)
                                {
                                    found = true;
                                    cout << " found " << endl;
                                    break;
                                }
                            }
                            if (found == false)

                            {
                                cout << " not found " << endl;
                            }

                            cout << " press anykey to countinue...... ";
                            getch();
                        } // update dishes
                        else if (adminoption == 4)
                        {
                            cout << " --------Old Record-------- " << endl;
                            for (int i = 0; i < count; i++)
                            {
                                if (dishes[i] != " ")
                                {
                                    cout << i + 1 << ". " << dishes[i] << " \t " << endl;
                                }
                            }
                            bool found = false;
                            string updatedish;
                            cout << " Enter Dish Name Do You Want To Update : ";
                            cin >> updatedish;
                            for (int i = 0; i < count; i++)
                            {
                                if (dishes[i] == updatedish)
                                {
                                    found = true;
                                    cout << " Enter New Dish Name : ";
                                    cin >> dishes[i];
                                    cout << "Your Record Successfully Updated " << endl;
                                    break;
                                }
                            }
                            if (found == false)
                            {
                                cout << " Your Entered Dish Is Not Found : " << endl;
                            }
                            cout << " Press Any Key To Countinue......... ";
                            getch();
                        } // delete dishes
                        else if (adminoption == 5)
                        {
                            bool found = false;
                            string deletedish;
                            cout << " Enter Dish Name Do You Want To Delete : ";
                            cin >> deletedish;
                            for (int i = 0; i < count; i++)
                            {
                                if (dishes[i] == deletedish)
                                {
                                    found = true;
                                    dishes[i] = " ";
                                    prices[i] = 0;
                                    cout << " your dish record deleted " << deletedish << endl;
                                    break;
                                }
                            }
                            if (found == false)
                            {
                                cout << " Dish not Found " << endl;
                            }
                            cout << " press Any Key To Countinue..... ";
                            getch();
                        }

                        else if (adminoption == 12)
                        {
                            // staff management
                            break;
                        }
                        else
                        {
                            cout << " Invalid Option " << endl;
                            getch();
                        }
                    } // admin main loop end

                    break;
                }
                else
                {
                    cout << " Username Or Password Is Invalid " << endl;
                }
                cout << " Press Any Key To Continue.... ";

                getch();
            } // login admin for loop end
        } // admin menu end

        else if (option == 2)
        {
            // Write here customer code
            while (true)
            {
                system("cls");
                cout << "============ WELCOME TO HM HOME KICHEN ============ " << endl;
                cout << "1.  View Mnue " << endl;
                cout << "2.  Search Dish " << endl;
                cout << "3.  Order Food " << endl;
                cout << "4.  View Current Order " << endl;
                cout << "5.  Remove Item From Order " << endl;
                cout << "6.  Update Quantity " << endl;
                cout << "7.  Calculate Bill " << endl;
                cout << "8.  Confirm Order " << endl;
                cout << "9.  View Order History " << endl;
                cout << "10. Exit " << endl;

                cout << " choose : ";
                int customeroption;
                cin >> customeroption;
                if (customeroption == 1)
                {

                    for (int i = 0; i < count; i++)
                    {
                        if (dishes[i] != " ")
                        {
                            cout << i + 1 << ". " << dishes[i] << " \t " << endl;
                        }
                    }

                    cout << " press anykey to countinue....... ";
                    getch();
                }
                else if (customeroption == 2)
                {
                    string searchdish;
                    cout << " Enter Search Dish Name :";
                    cin >> searchdish;
                    bool found = false;
                    for (int i = 0; i < count; i++)
                    {
                        if (dishes[i] == searchdish)
                        {
                            found = true;
                            cout << " found " << endl;
                            break;
                        }
                    }
                    if (found == false)

                    {
                        cout << " not found " << endl;
                    }

                    cout << " press anykey to countinue...... ";
                    getch();
                }
                else if (customeroption == 3)
                {
                    cout << " How many items do you want to order : ";
                    cin >> orders;
                    for (int i = 0; i < orders; i++)
                    {
                        cout << " Palace Order :";
                        cin >> orderdishes[i];
                        cout << " Dish Qantity : ";
                        cin >> orderquantity[i];
                        bool found = false;
                        for (int k = 0; k < count; k++)
                        {
                            if (orderdishes[i] == dishes[k])
                            {
                                found = true;
                                ordertotal[i] = prices[k] * orderquantity[i];
                                revenue = revenue + ordertotal[i];
                                break;
                            }
                        }
                        if (found == false)
                        {
                            cout<< " Item not found "<<endl;
                        }
                    }
                    cout << " press any key to countinue........";
                    getch();
                }
            }
        } // customer menu end
        else if (option == 3)
        {
            // write here staff code.
        } // staff mnue end
        else if (option == 4)
        {
            break;
        }
        else
        {
            cout << " You Entered Wrong Option " << endl;
        }
    } // main loop end
    cout << " Thanks For using This Software " << endl;
}
