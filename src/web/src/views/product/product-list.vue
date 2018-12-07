<template>
  <el-table :data="tableData" border style="width: 100%">
    <el-table-column fixed prop="productGUID" label="材料GUID" width="150"></el-table-column>
    <el-table-column fixed prop="pictures" label="图片" width="150">
      <img
        src="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1544177954687&di=5e796fc22f48dc89f63a9270aed0f10f&imgtype=0&src=http%3A%2F%2Fwww.hx116.com%2Fuserfiles%2F201811%2F20181117093651_11088.jpg"
        class="image"
      >
    </el-table-column>
    <el-table-column prop="productCode" label="材料编码" width="200"></el-table-column>
    <el-table-column prop="productName" label="材料名称" width="200"></el-table-column>
    <el-table-column prop="currentPrice" label="当前价格" width="100"></el-table-column>
    <el-table-column prop="providerName" label="供应商名称" width="200"></el-table-column>
    <el-table-column prop="unit" label="单位" width="120"></el-table-column>
    <el-table-column prop="remark" label="材料备注" width="120"></el-table-column>
    <el-table-column fixed="right" label="操作" width="100">
      <template slot-scope="scope">
        <el-button @click="handleClick(scope.row)" type="text" size="small">查看</el-button>
        <el-button type="text" size="small" @click="edit(scope.row)">编辑</el-button>
      </template>
    </el-table-column>
  </el-table>
</template>

<script>
export default {
  created() {
    this.getData();
  },

  methods: {
    getData() {
      var self = this;
      this.$http
        .get("/api/Product")
        .then(function(res) {
          console.log(res);
          self.tableData = res.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
    handleClick(row) {
      
      console.log(row);
    },
    edit(row) {
      console.log(row);
    }
  },

  data() {
    return {
      tableData: []
    };
  }
};
</script>