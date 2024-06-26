﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
public class Train {
    private Locomotive locomotive;
    private List<IWagon> wagons;

    public Locomotive Locomotive { get => locomotive; set => locomotive = value; }
    public List<IWagon> Wagons { get => wagons; set => wagons = value; }

    public Train() {
        this.wagons = new List<IWagon>();
    }
    public Train(Locomotive locomotive) : this() {
        this.locomotive = locomotive;
    }
    public Train(Locomotive locomotive, List<IWagon> wagons) : this(locomotive) {
        this.wagons = wagons;
    }
    public void ConnectToTrain(IWagon wagon) {
        wagon.ConnectToTrain(this);
    }
    public void DisconnectFromTrain(IWagon wagon) {
        wagon.DisconnectFromTrain(this);
    }
    public void ReserveChair(int wagon, int chairToReserve) {
        if (wagons.Count > wagon) {
            if (wagons[wagon].GetType().IsSubclassOf(typeof(PersonalWagon))) {
                string reservationStatus = "";
                foreach (Chair chair in ((PersonalWagon)Wagons[wagon]).Sits) {
                    if (chair.Number == chairToReserve) {
                        if (!chair.Reserved) {
                            chair.Reserved = true;
                            reservationStatus = "Sedadlo bylo uspesne rezervovano.";
                            break;
                        }
                        else {
                            reservationStatus = "Vami vybrane sedadlo je jiz zarezervovano.";
                            break;
                        }
                    }
                    else {
                        reservationStatus = "Vami zadane sedadlo ve vybranem voze neni.";
                    }
                }
                Console.WriteLine(reservationStatus);
            }
            else {
                Console.WriteLine("Vagon tohoto typu nenabizi mista k sezeni.");
            }
        }
        else {
            Console.WriteLine("Ve vybranem vlaku se nenachazi vagon s timto cislem.");
        }
    }
    public void ListReservedChairs() {
        string reservedChairs = "Seznam rezervovanych mist:";
        int i = 1;
        foreach (IWagon wagon in wagons) {
            reservedChairs += $"\n{i++}. vagon:";
            if (wagon.GetType().IsSubclassOf(typeof(PersonalWagon))) {
                foreach (Chair chair in ((PersonalWagon)wagon).Sits) {
                    if (chair.Reserved) {
                        reservedChairs += $" {chair.Number} ";
                    }
                }
            }
        }
        Console.WriteLine(reservedChairs);
    }
    public override string ToString() {
        string toString = $"{Locomotive}";
        foreach (IWagon wagon in this.Wagons) {
            toString += $"\n{wagon}";
        }
        return toString;
    }
}