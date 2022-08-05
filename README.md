# TrainReservationApi

Request example :

{
  "train": {
    "name": "Başkent Ekspres",
    "waggons": [
      {
        "name": "Vagon 1",
        "capacity": 100,
        "numberofReservedSeats": 68
      },
      {
        "name": "Vagon 2",
        "capacity": 90,
        "numberofReservedSeats": 50
      },
      {
        "name": "Vagon 3",
        "capacity": 80,
        "numberofReservedSeats": 80
      }
    ]
  },
  "numberofPassenger": 3,
  "isAllowDifferentWaggons": true
}

Response :

{
  "isReservable": true,
  "placementDetails": [
    {
      "waggonName": "Vagon 1",
      "numberofPeople": 1
    },
    {
      "waggonName": "Vagon 2",
      "numberofPeople": 2
    }
  ]
}
