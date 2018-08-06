<template>
  <div class="addemployee">
    <bt/>
    <h1>Witaj w oknie dodawania pracownika.</h1>
    <h2>Proszę o wypełnienie formularza.</h2>

      <div class="col-lg-4"></div>
        <div class="col-lg-4">
            <form method="post">
                <div class="form-group">
                  <label for="Name">Imie</label>
                  <input type="Name" class="form-control" id="Name" placeholder="Imie">
                </div>

                <div class="form-group">
                  <label for="LastName">Nazwisko</label>
                  <input type="LastName" class="form-control" id="LastName" placeholder="Nazwisko">
                </div>

                <div class="form-group">
                  <label for="Specialization">Specjalizacja</label>
                  <input type="Specialization" class="form-control"
                  id="Specialization" placeholder="Specjalizacja">
                </div>

                <div class="form-group">
                  <label for="Rating">Ocena</label>
                  <input type="Rating" class="form-control" id="Rating" placeholder="Ocena/Rating">
                </div>

                <div class="form-group">
                  <label for="YearsOfWork">Kadencja</label>
                  <input type="YearsOfWork" class="form-control"
                  id="YearsOfWork" placeholder="Ilość przepracowanych lat">
                </div>

                <button type="submit" class="btn btn-primary">Dodaj</button>
                <router-link to="/employee"><button type="submit" class="btn btn-info">
                  Wróć</button>
                </router-link>
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
