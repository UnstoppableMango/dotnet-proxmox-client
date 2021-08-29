namespace UnMango.Proxmox.Client.Abstractions.Storage
{
    public enum StorageType
    {
        BtrFs,
        CephFs,
        Cifs,
        Dir,
        GlusterFs,
        Iscsi,
        IscsiDirect,
        Lvm,
        LvmThin,
        Nfs,
        Pbs,
        Rbd,
        Zfs,
        ZfsPool,
    }
}
