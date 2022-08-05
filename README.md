# TrainReservationApi
<br />
Request example : <br />
<br />
{ <br />
  &nbsp "train": { <br />
  &nbsp  "name": "Başkent Ekspres", <br />
  &nbsp  "waggons": [ <br />
  &nbsp    { <br />
  &nbsp      "name": "Vagon 1", <br />
  &nbsp     "capacity": 100, <br />
  &nbsp      "numberofReservedSeats": 68 <br />
  &nbsp    }, <br />
  &nbsp    { <br />
  &nbsp      "name": "Vagon 2", <br />
  &nbsp      "capacity": 90, <br />
  &nbsp      "numberofReservedSeats": 50 <br />
  &nbsp    }, <br />
  &nbsp    { <br />
  &nbsp      "name": "Vagon 3", <br />
  &nbsp      "capacity": 80, <br />
  &nbsp      "numberofReservedSeats": 80 <br />
  &nbsp    } <br />
  &nbsp  ] <br />
  &nbsp }, <br />
  &nbsp "numberofPassenger": 3, <br />
  &nbsp "isAllowDifferentWaggons": true <br />
  &nbsp } <br />
  &nbsp<br />
  Response : <br />
  &nbsp <br />
  &nbsp { <br />
  &nbsp "isReservable": true, <br />
  &nbsp "placementDetails": [ <br />
  &nbsp  { <br />
  &nbsp    "waggonName": "Vagon 1", <br />
  &nbsp    "numberofPeople": 1 <br />
  &nbsp  }, <br />
  &nbsp  { <br />
  &nbsp    "waggonName": "Vagon 2", <br />
  &nbsp    "numberofPeople": 2 <br />
  &nbsp  } <br />
  &nbsp ] <br />
  &nbsp} <br />
