<template>
  <div class="addemployee">
    <bt/>
    <h1>Witaj w oknie dodawania pracownika.</h1>
    <h2>Proszę o wypełnienie formularza.</h2>

      <div class="col-lg-4"></div>
        <div class="col-lg-4">
          <!-- <form v-on:submit="addEmployee"> -->
                <div class="form-group">
                  <label for="Name">Imie</label>
                  <input type="Name" class="form-control" id="firstName"  placeholder="Imie">
                </div>

                <div class="form-group">
                  <label for="LastName">Nazwisko</label>
                  <input type="LastName" class="form-control" id="lastName"  placeholder="Nazwisko">
                </div>

                <div class="form-group">
                  <label for="Specialization">Specjalizacja</label>
                  <input type="Specialization" class="form-control"
                  id="specialization"    placeholder="Specjalizacja">
                </div>

                <div class="form-group">
                  <label for="Rating">Ocena</label>
                  <input type="Rating" class="form-control" id="rating"  placeholder="Ocena/Rating">
                </div>

                <div class="form-group">
                  <label for="YearsOfWork">Kadencja</label>
                  <input type="YearsOfWork" class="form-control"
                  id="yearsOfWork"  placeholder="Ilość przepracowanych lat">
                </div>

                <button type="submit" class="btn btn-primary">Dodaj pracownika</button>
                <router-link to="/employee"><button type="submit" class="btn btn-info">
                  Wróć</button>
                </router-link>
            <!-- </form> -->
        </div>
      <div class="col-lg-4"></div>
  </div>
</template>


<script>
import axios from 'axios';

export default {
  data() {
    return {
      employees: [],
      errors: [],
      alert: ''
    }
  },

    methods: {
    // addEmployee(a){
    //   if(!this.employees.firstName || !this.employees.lastName || !this.employees.specialization || this.employees.rating || this.employees.yearsOfWork){
    //     this.alert="Uzupełnij wszystkie pola";
    //   }else{
    //     let newEmployee={
    //       firstName:this.employees.firstName,
    //       lastName:this.employees.lastName,
    //       specialization:this.employees.specialization,
    //       rating:this.employees.rating,
    //       yearsOfWork:this.employees.yearsOfWork
    //     }

    //     this.$http.post('http://localhost:4444/api/employees/AddEmployee', newEmployee)
    //     .then(function(response){
    //       this.$router.push({path: '/addemployee', query: {alert: 'Customer Added'}});
    //     })
    //   }
    // },

      }

};

</script>


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
