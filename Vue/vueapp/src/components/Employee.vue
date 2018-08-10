s<template>
  <div class="employeeclass">
    <h1>Widok pracownika</h1>

    <br/><br/><br/>

    <div class="col-lg-3"></div>
    <div class="col-lg-6">
      <router-link to="/addemployee"><button class="btn btn-primary"
        style="float:left; margin-bottom:20px;">Dodaj pracownika</button></router-link>

        <table class="table table-hover" >
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Imie</th>
                    <th>Nazwisko</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="emp in employees" :key="emp.Id">
                    <td align="left">{{emp.profile.id}}</td>
                    <td align="left">{{emp.profile.name}}</td>
                    <td align="left">{{emp.profile.lastName}}</td>
                    <td style="margin-left:5px;">
                      <router-link to="/editemployee"><button class="btn btn-primary">Edytuj</button></router-link>
                      <button class="btn btn-danger" v-on:click="deleteEmployee">Usuń</button>
                      <button class="btn btn-success">Karta</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="col-lg-3"></div>
  </div>
</template>

<script>
// https://alligator.io/vuejs/rest-api-axios/
// Access-Control-Allow-Origin: *

import axios from 'axios';

export default {
  data() {
    return {
      employees: [],
      errors: [],
      alert: ''
    }
  },

  // Fetches posts when the component is created.
  created() {
    axios.get('http://localhost:4444/api/employees/GetEmployees')
    .then(response => {
        this.employees = response.data;
      })
      .catch(e => {
        this.errors.push(e);
      });
  },

  methods: {

    deleteEmployee(){
     axios.delete('http://localhost:4444/api/employees/Delete' , {
       body:this.employees
     })
     .then(response=>{})
   },

    editEmployee(){
     axios.get('http://localhost:4444/api/employees/GetEdit')
     .then(response => {
       this.employees=response.data;
     })
     .catch(e => {
       this.errors.push(e);
     });
   },
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
