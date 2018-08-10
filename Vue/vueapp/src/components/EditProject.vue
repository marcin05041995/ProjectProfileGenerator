<template>
  <div class="addproject">
    <bt/>
    <h1>Witaj w oknie edycji projektu.</h1>
    <h2>Proszę o wypełnienie formularza.</h2>
      <div class="col-lg-4"></div>
        <div class="col-lg-4">
          <form>
            <div class="form-group">
              <label for="Title">Tytuł</label>
              <input type="Title" class="form-control" id="Title" placeholder="Tytuł">
            </div>

            <div class="form-group">
              <label for="ClientSector">Sektor klienta</label>
              <input type="ClientSector" class="form-control"
                id="ClientSector" placeholder="Sektor klienta">
            </div>

            <div class="form-group">
              <label for="Technologies">Technologie</label>
              <input type="Technologies" class="form-control"
               id="Technologies" placeholder="Technologie">
            </div>

            <div class="form-group">
              <label for="StartDate">Data rozpoczęcia projektu</label>
              <input type="StartDate" class="form-control"
               id="StartDate" placeholder="Data rozpoczęcia projektu">
            </div>

            <div class="form-group">
              <label for="EndDate">Data zakończenia projektu</label>
              <input type="EndDate" class="form-control"
               id="EndDate" placeholder="Data zakończenia projektu">
            </div>

            <button type="submit" class="btn btn-primary">Zapisz zmiany</button>
            <router-link to="/project"><button type="submit" class="btn btn-info">
              Wróć</button></router-link>
          </form>
        </div>
      <div class="col-lg-4"></div>
  </div>
</template>

<style scoped>
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
