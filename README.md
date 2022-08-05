# TrainReservationApi
<br />
Request example : <br />
<br />
{ <br />
  "train": { <br />
    "name": "Başkent Ekspres", <br />
    "waggons": [ <br />
      { <br />
        "name": "Vagon 1", <br />
        "capacity": 100, <br />
        "numberofReservedSeats": 68 <br />
      }, <br />
      { <br />
        "name": "Vagon 2", <br />
        "capacity": 90, <br />
        "numberofReservedSeats": 50 <br />
      }, <br />
      { <br />
        "name": "Vagon 3", <br />
        "capacity": 80, <br />
        "numberofReservedSeats": 80 <br />
      } <br />
    ] <br />
  }, <br />
  "numberofPassenger": 3, <br />
  "isAllowDifferentWaggons": true <br />
} <br />
 <br />
Response : <br />
 <br />
{ <br />
  "isReservable": true, <br />
  "placementDetails": [ <br />
    { <br />
      "waggonName": "Vagon 1", <br />
      "numberofPeople": 1 <br />
    }, <br />
    { <br />
      "waggonName": "Vagon 2", <br />
      "numberofPeople": 2 <br />
    } <br />
  ] <br />
} <br />
