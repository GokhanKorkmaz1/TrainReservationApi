using ReservationApi.Business.Abstract;
using ReservationApi.Models;

namespace ReservationApi.Business.Concrete
{
    public class ReservationManager : IReservationService
    {

        public ReservationResponse Add(Reservation reservation)
        {
            var train = reservation.Train;
            var waggon = calculateNumberofMaxEmptySeat(train);

            ReservationResponse reservationResponse = new ReservationResponse
            {
                IsReservable = false
            };
            if(reservation.NumberofPassenger==0)
                return reservationResponse;

            if (calculateTotalCapacity(train, reservation.NumberofPassenger))
            {
                if (!reservation.IsAllowDifferentWaggons)
                {
                    if (calculateSeventyPercent(waggon, reservation.NumberofPassenger))
                    {
                        reservationResponse.IsReservable = true;

                        PlacementDetail placementDetail = new PlacementDetail
                        {
                            NumberofPeople = reservation.NumberofPassenger,
                            WaggonName = waggon.Name
                        };
                        reservationResponse.PlacementDetails.Add(placementDetail);

                    }

                }
                else
                {
                    reserveDifferentWaggons(reservation, reservationResponse, train);
                }
            }
            return reservationResponse;
        }

        //compares total capacity and number of passenger and return true or false value
        public bool calculateTotalCapacity(Train train, int numberofPassenger)
        {
            int totalCapacity=0;
            foreach (var waggon in train.Waggons)
            {
                    if(waggon.Capacity * 0.7 % Math.Floor(waggon.Capacity * 0.7)  == 0)
                    {
                        totalCapacity = (int)(waggon.Capacity * 0.7) - (waggon.NumberofReservedSeats + 1) > 0 ?
                        totalCapacity + (int)(waggon.Capacity * 0.7) - (waggon.NumberofReservedSeats+1) : totalCapacity;
                    }
                    else
                    {
                        totalCapacity = (int)(waggon.Capacity * 0.7) - waggon.NumberofReservedSeats > 0 ?
                        totalCapacity + (int)(waggon.Capacity * 0.7) - waggon.NumberofReservedSeats : totalCapacity;
                    }
            }
            return totalCapacity >= numberofPassenger ? true : false;
        }


        //finds the wagon with the lowest occupancy rate on the train
        public Waggon calculateNumberofMaxEmptySeat(Train train)
        {
            Waggon haveMaxEmptySeat = train.Waggons[0];
            foreach (var waggon in train.Waggons)
            {
                if ((haveMaxEmptySeat.Capacity - haveMaxEmptySeat.NumberofReservedSeats) < (waggon.Capacity - waggon.NumberofReservedSeats))
                {
                    haveMaxEmptySeat = waggon;
                }
            }
            return haveMaxEmptySeat;
        }

        /// <summary>
        ///  This method compares the number of reserved seats and the number of passengers 
        ///  in the reservation request with the wagon capacity and returns a true false value.
        /// </summary>
        public bool calculateSeventyPercent(Waggon waggon, int numberofPassanger)
        {
            if ((double)(waggon.NumberofReservedSeats + numberofPassanger) / waggon.Capacity < 0.7)
                return true;
            if(numberofPassanger==0)
                return true;
            return false;
        }

        public void reserveDifferentWaggons(Reservation reservation, ReservationResponse reservationResponse, Train train)
        {
            int passangerCount;
            var remainder = reservation.NumberofPassenger;
            foreach (var waggon1 in train.Waggons)
            {
                passangerCount = remainder;
                while (!calculateSeventyPercent(waggon1, passangerCount))
                {
                    passangerCount--;
                }
                if (passangerCount > 0 && passangerCount <= remainder)
                {
                    PlacementDetail placementDetail = new PlacementDetail
                    {
                        NumberofPeople = passangerCount,
                        WaggonName = waggon1.Name
                    };
                    reservationResponse.PlacementDetails.Add(placementDetail);
                    remainder -= passangerCount;
                }
                if (remainder == 0)
                {
                    reservationResponse.IsReservable = true;
                    break;
                }
            }

        }

    }
}
