<template>
  <div class="employeeclass">
    <bt/>
    <h1>Widok pracownika</h1>

    <br/><br/><br/>

    <div class="col-lg-3"></div>
    <div class="col-lg-6">
      <router-link to="/addemployee"><button class="btn btn-primary"
        style="float:left; margin-bottom:20px;">Dodaj pracownika</button></router-link>

        <table class="table table-hover" method="get">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td align="left" >1</td>
                    <td align="left">John</td>
                    <td align="left">Carter</td>
                </tr>
                <tr>
                    <td align="left">2</td>
                    <td align="left">Peter</td>
                    <td align="left">Parker</td>
                </tr>
                <tr>
                    <td align="left">3</td>
                    <td align="left">John</td>
                    <td align="left">Rambo</td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="col-lg-3"></div>


  </div>
</template>

<script>
export default {
  name: 'Employee',
  data() {
    return {
      msg: 'Witaj w aplikacji do zarządzania pracownikami!',
    };
  },
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
